using Newtonsoft.Json;
using Vrudi_MVP_BE.DTOs;

namespace Vrudi_MVP_BE.Helpers.Services
{
    public class DataWrapperService
    {
        public static string WrapData(string message, bool isSuccess, Object obj = null)
        {
            DataWrapper wrapper = new DataWrapper();
            wrapper.success = isSuccess;
            wrapper.message = message;
            wrapper.data = new ();
            wrapper.data.dataObject = obj;
            return JsonConvert.SerializeObject(wrapper);
        }
    }
}
