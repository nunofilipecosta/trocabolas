namespace TrocaBolas.Web.Builders
{
    using System;

    public interface IViewModelBuilder<TIn, TOut>
    {
        TOut Build(TIn domain);

        TOut Build(Guid id);

        TOut Rebuild(TOut viewModel);
    }
}