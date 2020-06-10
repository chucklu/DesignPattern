﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    /// <summary>

    /// A 'ConcreteColleague' class

    /// </summary>

    class Beatle : Participant

    {

        // Constructor

        public Beatle(string name)

          : base(name)

        {

        }



        public override void Receive(string from, string message)

        {

            Console.Write("To a Beatle: ");

            base.Receive(from, message);

        }

    }



    /// <summary>

    /// A 'ConcreteColleague' class

    /// </summary>

    class NonBeatle : Participant

    {

        // Constructor

        public NonBeatle(string name)

          : base(name)

        {

        }



        public override void Receive(string from, string message)

        {

            Console.Write("To a non-Beatle: ");

            base.Receive(from, message);

        }

    }
}
