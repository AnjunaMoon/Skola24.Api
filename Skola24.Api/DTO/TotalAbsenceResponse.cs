using System.Runtime.Serialization;

namespace Skola24.Api.DTO
{
    [DataContract]
    public class TotalAbsenceResponse : ResponseBase
    {
        [DataMember]
        public int Absence { get; set; }
    }

}
