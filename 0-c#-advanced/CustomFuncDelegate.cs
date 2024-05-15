using System;


namespace CSharpJourney{

    public delegate TResult CustomFunc<in T, out TResult>(T arg);

}