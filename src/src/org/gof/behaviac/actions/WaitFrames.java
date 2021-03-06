package org.gof.behaviac.actions;

import java.util.List;

import org.gof.behaviac.Agent;
import org.gof.behaviac.AgentMeta;
import org.gof.behaviac.BehaviorNode;
import org.gof.behaviac.BehaviorTask;
import org.gof.behaviac.Debug;
import org.gof.behaviac.EBTStatus;
import org.gof.behaviac.LeafTask;
import org.gof.behaviac.RegisterableNode;
import org.gof.behaviac.property_t;
import org.gof.behaviac.members.CInstanceMember;
import org.gof.behaviac.members.IInstanceMember;

@RegisterableNode
public class WaitFrames extends BehaviorNode {
	private IInstanceMember m_frames;

	@Override
	protected void load(int version, String agentType, List<property_t> properties) {
		// TODO Auto-generated method stub
		super.load(version, agentType, properties);
		for (int i = 0; i < properties.size(); ++i) {
			property_t p = properties.get(i);

			if (p.name .equals( "Frames")) {
				int pParenthesis = p.value.indexOf('(');

				if (pParenthesis == -1) {
					this.m_frames = AgentMeta.ParseProperty(p.value);
				} else {
					this.m_frames = AgentMeta.ParseMethod(p.value);
				}
			}
		}
	}

	protected int GetFrames(Agent pAgent) {
		if (this.m_frames != null) {
			Debug.Check(this.m_frames instanceof CInstanceMember);
			return (int) this.m_frames.GetValueObject(pAgent);
		}
		return 0;
	}

	@Override
	protected BehaviorTask createTask() {
		WaitFramesTask pTask = new WaitFramesTask();

		return pTask;
	}

	private static class WaitFramesTask extends LeafTask {
		@Override
		public void copyto(BehaviorTask target) {
			super.copyto(target);

			Debug.Check(target instanceof WaitFramesTask);
			WaitFramesTask ttask = (WaitFramesTask) target;
			ttask.m_start = this.m_start;
			ttask.m_frames = this.m_frames;
		}

		@Override
		protected boolean onenter(Agent pAgent) {
			this.m_start = pAgent.GetFrameSinceStartup();
			this.m_frames = this.GetFrames(pAgent);

			return (this.m_frames >= 0);
		}

		@Override
		protected org.gof.behaviac.EBTStatus update(Agent pAgent, org.gof.behaviac.EBTStatus childStatus) {
			Debug.Check(childStatus == EBTStatus.BT_RUNNING);

			if (pAgent.GetFrameSinceStartup() - this.m_start + 1 >= this.m_frames) {
				return EBTStatus.BT_SUCCESS;
			}

			return EBTStatus.BT_RUNNING;
		}

		private long GetFrames(Agent pAgent) {
			Debug.Check(this.GetNode() instanceof WaitFrames);
			WaitFrames pWaitNode = (WaitFrames) (this.GetNode());
			return pWaitNode != null ? pWaitNode.GetFrames(pAgent) : 0;
		}

		private long m_start;
		private long m_frames;
	}

}
