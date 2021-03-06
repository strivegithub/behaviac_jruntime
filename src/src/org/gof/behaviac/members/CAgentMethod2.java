package org.gof.behaviac.members;

import org.gof.behaviac.Agent;
import org.gof.behaviac.AgentMeta;
import org.gof.behaviac.BehaviorTreeTask;
import org.gof.behaviac.ClassInfo;
import org.gof.behaviac.Debug;
import org.gof.behaviac.htn.Task;
import org.gof.behaviac.utils.Func3;

public class CAgentMethod2<R, P1, P2> extends CAgentMethodBase {
	Func3<R, Agent, P1, P2> _fp;
	IInstanceMember _p1;
	IInstanceMember _p2;

	public CAgentMethod2(Func3<R, Agent, P1, P2> f, ClassInfo rclazz, ClassInfo[] pclazzs) {
		super(rclazz, pclazzs);
		_fp = f;
	}

	public CAgentMethod2(CAgentMethod2<R, P1, P2> rhs) {
		super(rhs);
		_fp = rhs._fp;
		_p1 = rhs._p1;
		_p2 = rhs._p2;
	}

	@Override
	public IMethod Clone() {
		return new CAgentMethod2<R, P1, P2>(this);
	}

	@Override
	public void Load(String instance, String[] paramStrs) {
		Debug.Check(paramStrs.length == 2);
		_instance = instance;
		_p1 = AgentMeta.ParseProperty(paramStrs[0], _pclazzs[0]);
		_p2 = AgentMeta.ParseProperty(paramStrs[1], _pclazzs[1]);
	}

	@SuppressWarnings("unchecked")
	@Override
	public void Run(Agent self) {

		_returnValue.value = _fp.run(self, (P1) _p1.GetValueObject(self), (P2) _p2.GetValueObject(self));
	}

	@Override
	public void SetTaskParams(Agent self, BehaviorTreeTask treeTask) {
		String paramName = String.format("%s%d", Task.LOCAL_TASK_PARAM_PRE, 0);
		treeTask.SetVariable(paramName, _p1.GetValueObject(self));
		
		paramName = String.format("%s%d", Task.LOCAL_TASK_PARAM_PRE, 1);
		treeTask.SetVariable(paramName, _p2.GetValueObject(self));
		
	}
}
