using System;
using System.Diagnostics.CodeAnalysis;

namespace TrocaBolas.Web.Builders
{
    public interface IDomainBuilder<TIn, TOut>
    {
        TOut Build(TIn viewModel);
    }
}