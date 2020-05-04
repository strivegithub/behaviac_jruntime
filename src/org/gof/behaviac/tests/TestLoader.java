package org.gof.behaviac.tests;

import org.gof.behaviac.AgentMeta;
import org.gof.behaviac.BehaviorLoader;
import org.gof.behaviac.EBTStatus;
import org.gof.behaviac.Workspace;
import org.junit.Test;

import loader.BehaviorLoaderImplement;
import testbehaviac.x1.MyAgent2;

public class TestLoader {

	@Test
	public void Test1() {
		try {
			Workspace.Instance.SetFilePath("I:\\workspace\\behaviac_jruntime\\testworkspace\\exported");
			AgentMeta.SetBehaviorLoader(new BehaviorLoaderImplement() {
			});
			var agent = new MyAgent2();
			agent.btsetcurrent("b1");
			while( agent.btexec() == EBTStatus.BT_RUNNING) {
				System.out.println("running " + System.currentTimeMillis());
				Thread.sleep(300);
			}
		} catch (Exception e) {
			e.printStackTrace();
		}
	}
}
