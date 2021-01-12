using System;
using System.Collections.Generic;
using System.Text;

namespace MediatR.MediatR_Custom
{

    public class ChannelAbstract
    {
        IMediatR mediatr;
        
        public ChannelAbstract(IMediatR mediatr)
        {
            this.mediatr = mediatr;
        }
    }


    public class MediatorRChannel1 : ChannelAbstract
    {
        IMediatR mediatr;

        public MediatorRChannel1(IMediatR mediatr): base(mediatr)
        {
            this.mediatr = mediatr;
        }

        public void Send(string message)
        {
            this.mediatr.send("c1" ,  message);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Channel 1 notified:- " + message);
        }

    }


    public class MediatorRChannel2 : ChannelAbstract
    {
        IMediatR mediatr;
        public MediatorRChannel2(IMediatR mediatr) : base(mediatr)
        {
            this.mediatr = mediatr;
        }

        public void Send(string message)
        {
            this.mediatr.send("c2", message);
        }


        public void Notify(string message)
        {
            Console.WriteLine("Channel 2 notified:- " + message);
        }
    }
}
