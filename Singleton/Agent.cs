using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Agent:IAgent
    {
        private static readonly AgentSingleton singleton = new AgentSingleton();

        public static IAgent Instance
        {
            get
            {
                try
                {
                    return singleton.ExistingInstance;
                }
                catch (NullReferenceException)
                {
                    return null;
                }
            }
        }
        private sealed class AgentSingleton : Singleton<IAgent>
        {
            public AgentSingleton()
                : base(null)
            {
            }

            protected override IAgent CreateInstance()
            {
                 Agent agent = new Agent();
                 return agent;  
            }

         
        }
    }
}
