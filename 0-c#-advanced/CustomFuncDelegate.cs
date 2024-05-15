using System;


namespace CSharpJourney{

    public delegate TResult CustomFunc<in T, out TResult>(T arg);

    public delegate TResult CustomFunc<in T1, in T2, out TResult>(T1 arg1, T2 arg2);

    public delegate TResult CustomFunc<in T1, in T2, in T3, out TResult>(T1 arg1, T2 arg2, T3 arg3);

    public delegate void CustomAction<in T>(T arg);

    public delegate void CustomAction<in T1, in T2>(T1 arg1, T2 arg2);

    public delegate void CustomAction<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3);

}