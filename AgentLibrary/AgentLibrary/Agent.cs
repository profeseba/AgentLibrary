using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AgentLibrary
{
    public abstract class Agent 
    {
        public abstract Object sensor();

        private void Update()
        {
            while (true)
            {
                actuador(comportamiento(sensor()));
            }
        }

        public abstract String comportamiento(Object obj);

        public abstract void actuador(String accion);

        public void start()
        {
            Thread cal = new Thread(new ThreadStart(Update));
            cal.Start();
        }
    }
}
