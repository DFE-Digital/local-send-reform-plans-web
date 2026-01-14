namespace GovUK.Dfe.LocalSendReformPlans.Application.Interfaces
{
    public interface IComplexFieldRendererFactory
    {
        IComplexFieldRenderer GetRenderer(string fieldType);
    }
} 
