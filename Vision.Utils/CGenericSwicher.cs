﻿using System;

namespace Apteka.Utils
{
    public class Switch
    {
        public Switch(Object o)
        {
            Object = o;
        }

        public Object Object { get; private set; }
    }


    /// <summary>
    /// Extensions, because otherwise casing fails on Switch==null
    /// </summary>
    public static class SwitchExtensions
    {
        public static Switch Case<T>(this Switch s, Action<T> a)  where T : class
        {
            return Case(s, o => true, a, false);
        }

        public static Switch Case<T>(this Switch s, Action<T> a, bool fallThrough) where T : class
        {
            return Case(s, o => true, a, fallThrough);
        }

        public static Switch Case<T>(this Switch s, Func<T, bool> c, Action<T> a) where T : class
        {
            return Case(s, c, a, false);
        }

        public static Switch Case<T>(this Switch s, Func<T, bool> c, Action<T> a, bool fallThrough) where T : class
        {
            if (s == null)
            {
                return null;
            }

            if (s.Object is T t)
            {
                if (c(t))
                {
                    a(t);
                    return fallThrough ? s : null;
                }
            }

            return s;
        }



    }


    /*
     new Switch(foo)
     .Case<Fizz>
         (action => { doingSomething = FirstMethodCall();
        })
     .Case<Buzz>
         (action => { return false; })
         */
}
