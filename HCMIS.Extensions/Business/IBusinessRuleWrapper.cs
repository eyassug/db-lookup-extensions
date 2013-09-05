namespace HCMIS.Extensions.Business
{
    public interface IBusinessRuleWrapper<out TType> where TType: class 
    {
        TType Get(string businessRule);
    }
}
