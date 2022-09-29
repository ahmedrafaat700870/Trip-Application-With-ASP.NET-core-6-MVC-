namespace Tourest.BL.CustomeModel
{
    public class CusTourOption
    {
        public CusTourOption()
        {
            TbTourOption = new List<CusTourOption>();
        }
        public int UserCount { get; set; }
        public List<CusTourOption> TbTourOption {get;set; }
    }
}
