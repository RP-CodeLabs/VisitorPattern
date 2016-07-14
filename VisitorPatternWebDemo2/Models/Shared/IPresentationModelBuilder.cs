namespace VisitorPatternWebDemo2.Models.Shared
{
    public interface IPresentationModelBuilder
    {
        PresentationModel Build(Context buildContext);
    }
}
