using System;
using System.Collections.Generic;
using System.Text;

namespace MediatR.MediatR_Custom
{
    public interface IMediatR
    {
        void send(string from, string message);
    }


    public class MediatRImplementation : IMediatR
    {

        MediatorRChannel1 channel1;
        MediatorRChannel2 channel2;

        public MediatorRChannel1 SetChannel1 
        {
            set { channel1 = value; }
        }

        public MediatorRChannel2 SetChannel2
        {
            set { channel2 = value; }    
        }


        public void send(string from, string message)
        {

            if (from == "c1")
                channel2.Notify(message);
            else
                channel1.Notify(message);
        
        }
    }

}
