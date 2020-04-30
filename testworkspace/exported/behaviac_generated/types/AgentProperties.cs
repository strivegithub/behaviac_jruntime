﻿// ---------------------------------------------------------------------
// THIS FILE IS AUTO-GENERATED BY BEHAVIAC DESIGNER, SO PLEASE DON'T MODIFY IT BY YOURSELF!
// ---------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;

namespace behaviac
{

	public class BehaviorLoaderImplement : BehaviorLoader
	{
		private class CMethod_behaviac_Agent_VectorAdd : CAgentMethodVoidBase
		{
			IInstanceMember _param0;
			IInstanceMember _param1;

			public CMethod_behaviac_Agent_VectorAdd()
			{
			}

			public CMethod_behaviac_Agent_VectorAdd(CMethod_behaviac_Agent_VectorAdd rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorAdd(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 2);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
				_param1 = AgentMeta.ParseProperty<System.Object>(paramStrs[1]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);
				Debug.Check(_param1 != null);

				behaviac.Agent.VectorAdd((IList)_param0.GetValueObject(self), (System.Object)_param1.GetValueObject(self));
			}
		}

		private class CMethod_behaviac_Agent_VectorClear : CAgentMethodVoidBase
		{
			IInstanceMember _param0;

			public CMethod_behaviac_Agent_VectorClear()
			{
			}

			public CMethod_behaviac_Agent_VectorClear(CMethod_behaviac_Agent_VectorClear rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorClear(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 1);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);

				behaviac.Agent.VectorClear((IList)_param0.GetValueObject(self));
			}
		}

		private class CMethod_behaviac_Agent_VectorContains : CAgentMethodBase<bool>
		{
			IInstanceMember _param0;
			IInstanceMember _param1;

			public CMethod_behaviac_Agent_VectorContains()
			{
			}

			public CMethod_behaviac_Agent_VectorContains(CMethod_behaviac_Agent_VectorContains rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorContains(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 2);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
				_param1 = AgentMeta.ParseProperty<System.Object>(paramStrs[1]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);
				Debug.Check(_param1 != null);

				_returnValue.value = behaviac.Agent.VectorContains((IList)_param0.GetValueObject(self), (System.Object)_param1.GetValueObject(self));
			}
		}

		private class CMethod_behaviac_Agent_VectorLength : CAgentMethodBase<int>
		{
			IInstanceMember _param0;

			public CMethod_behaviac_Agent_VectorLength()
			{
			}

			public CMethod_behaviac_Agent_VectorLength(CMethod_behaviac_Agent_VectorLength rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorLength(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 1);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);

				_returnValue.value = behaviac.Agent.VectorLength((IList)_param0.GetValueObject(self));
			}
		}

		private class CMethod_behaviac_Agent_VectorRemove : CAgentMethodVoidBase
		{
			IInstanceMember _param0;
			IInstanceMember _param1;

			public CMethod_behaviac_Agent_VectorRemove()
			{
			}

			public CMethod_behaviac_Agent_VectorRemove(CMethod_behaviac_Agent_VectorRemove rhs) : base(rhs)
			{
			}

			public override IMethod Clone()
			{
				return new CMethod_behaviac_Agent_VectorRemove(this);
			}

			public override void Load(string instance, string[] paramStrs)
			{
				Debug.Check(paramStrs.Length == 2);

				_instance = instance;
				_param0 = AgentMeta.ParseProperty<IList>(paramStrs[0]);
				_param1 = AgentMeta.ParseProperty<System.Object>(paramStrs[1]);
			}

			public override void Run(Agent self)
			{
				Debug.Check(_param0 != null);
				Debug.Check(_param1 != null);

				behaviac.Agent.VectorRemove((IList)_param0.GetValueObject(self), (System.Object)_param1.GetValueObject(self));
			}
		}


		public override bool Load()
		{
			AgentMeta.TotalSignature = 1864371017;

			AgentMeta meta;

			// behaviac.Agent
			meta = new AgentMeta(24743406);
			AgentMeta._AgentMetas_[2436498804] = meta;
			meta.RegisterMethod(1045109914, new CAgentStaticMethodVoid<string>(delegate(string param0) { behaviac.Agent.LogMessage(param0); }));
			meta.RegisterMethod(2521019022, new CMethod_behaviac_Agent_VectorAdd());
			meta.RegisterMethod(2306090221, new CMethod_behaviac_Agent_VectorClear());
			meta.RegisterMethod(3483755530, new CMethod_behaviac_Agent_VectorContains());
			meta.RegisterMethod(505785840, new CMethod_behaviac_Agent_VectorLength());
			meta.RegisterMethod(502968959, new CMethod_behaviac_Agent_VectorRemove());

			// org.gof.worldsrv.MyAgent
			meta = new AgentMeta(799281323);
			AgentMeta._AgentMetas_[467449450] = meta;
			meta.RegisterMemberProperty(2119865978, new CStaticMemberProperty<ushort>("s1", delegate(ushort value) { org.gof.worldsrv.MyAgent.s1 = value; }, delegate() { return org.gof.worldsrv.MyAgent.s1; }));
			meta.RegisterMemberProperty(1433912761, new CStaticMemberProperty<long>("s2", delegate(long value) {  }, delegate() { return org.gof.worldsrv.MyAgent._get_s2(); }));
			meta.RegisterMemberProperty(2022790289, new CMemberProperty<behaviac.EBTStatus>("v1", delegate(Agent self, behaviac.EBTStatus value) { ((org.gof.worldsrv.MyAgent)self)._set_v1(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v1(); }));
			meta.RegisterMemberProperty(3927049740, new CMemberProperty<List<behaviac.EBTStatus>>("v11", delegate(Agent self, List<behaviac.EBTStatus> value) { ((org.gof.worldsrv.MyAgent)self)._set_v11(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v11(); }));
			meta.RegisterMemberProperty(1476831413, new CMemberArrayItemProperty<behaviac.EBTStatus>("v11[]", delegate(Agent self, behaviac.EBTStatus value, int index) { ((org.gof.worldsrv.MyAgent)self)._get_v11()[index] = value; }, delegate(Agent self, int index) { return ((org.gof.worldsrv.MyAgent)self)._get_v11()[index]; }));
			meta.RegisterMemberProperty(3242153423, new CMemberProperty<List<bool>>("v12", delegate(Agent self, List<bool> value) { ((org.gof.worldsrv.MyAgent)self)._set_v12(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v12(); }));
			meta.RegisterMemberProperty(1253246811, new CMemberArrayItemProperty<bool>("v12[]", delegate(Agent self, bool value, int index) { ((org.gof.worldsrv.MyAgent)self)._get_v12()[index] = value; }, delegate(Agent self, int index) { return ((org.gof.worldsrv.MyAgent)self)._get_v12()[index]; }));
			meta.RegisterMemberProperty(3626263694, new CMemberProperty<int>("v13", delegate(Agent self, int value) { ((org.gof.worldsrv.MyAgent)self)._set_v13(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v13(); }));
			meta.RegisterMemberProperty(2540040777, new CMemberProperty<float>("v14", delegate(Agent self, float value) { ((org.gof.worldsrv.MyAgent)self)._set_v14(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v14(); }));
			meta.RegisterMemberProperty(2390672136, new CMemberProperty<double>("v15", delegate(Agent self, double value) { ((org.gof.worldsrv.MyAgent)self)._set_v15(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v15(); }));
			meta.RegisterMemberProperty(2773717195, new CMemberProperty<string>("v16", delegate(Agent self, string value) { ((org.gof.worldsrv.MyAgent)self)._set_v16(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v16(); }));
			meta.RegisterMemberProperty(1404831570, new CMemberProperty<bool>("v2", delegate(Agent self, bool value) { ((org.gof.worldsrv.MyAgent)self)._set_v2(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v2(); }));
			meta.RegisterMemberProperty(1252472339, new CMemberProperty<int>("v3", delegate(Agent self, int value) { ((org.gof.worldsrv.MyAgent)self)._set_v3(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v3(); }));
			meta.RegisterMemberProperty(99000532, new CMemberProperty<uint>("v4", delegate(Agent self, uint value) { ((org.gof.worldsrv.MyAgent)self)._set_v4(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v4(); }));
			meta.RegisterMemberProperty(486379925, new CMemberProperty<float>("v5", delegate(Agent self, float value) { ((org.gof.worldsrv.MyAgent)self)._set_v5(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v5(); }));
			meta.RegisterMemberProperty(936428118, new CMemberProperty<double>("v6", delegate(Agent self, double value) { ((org.gof.worldsrv.MyAgent)self)._set_v6(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v6(); }));
			meta.RegisterMemberProperty(785117975, new CMemberProperty<string>("v7", delegate(Agent self, string value) { ((org.gof.worldsrv.MyAgent)self)._set_v7(value); }, delegate(Agent self) { return ((org.gof.worldsrv.MyAgent)self)._get_v7(); }));
			meta.RegisterMethod(1045109914, new CAgentStaticMethodVoid<string>(delegate(string param0) { org.gof.worldsrv.MyAgent.LogMessage(param0); }));
			meta.RegisterMethod(1759647744, new CAgentMethod<behaviac.EBTStatus, bool, uint, float, string, long, List<bool>, List<int>, double>(delegate(Agent self, bool v1, uint v2, float v3, string v4, long v5, List<bool> v11, List<int> v12, double v13) { return ((org.gof.worldsrv.MyAgent)self).m1(v1, v2, v3, v4, v5, v11, v12, v13); }));
			meta.RegisterMethod(4058224632, new CAgentMethodVoid<List<short>>(delegate(Agent self, List<short> v1) { }) /* task1 */);
			meta.RegisterMethod(2521019022, new CMethod_behaviac_Agent_VectorAdd());
			meta.RegisterMethod(2306090221, new CMethod_behaviac_Agent_VectorClear());
			meta.RegisterMethod(3483755530, new CMethod_behaviac_Agent_VectorContains());
			meta.RegisterMethod(505785840, new CMethod_behaviac_Agent_VectorLength());
			meta.RegisterMethod(502968959, new CMethod_behaviac_Agent_VectorRemove());

			AgentMeta.Register<behaviac.Agent>("behaviac.Agent");
			AgentMeta.Register<org.gof.worldsrv.MyAgent>("org.gof.worldsrv.MyAgent");
			return true;
		}

		public override bool UnLoad()
		{
			AgentMeta.UnRegister<behaviac.Agent>("behaviac.Agent");
			AgentMeta.UnRegister<org.gof.worldsrv.MyAgent>("org.gof.worldsrv.MyAgent");
			return true;
		}
	}
}
