using YOMS.AppV1.Models.DTO;

namespace YOMS.AppV1.Services
{
    public interface IApplicantService
    {
        Task<ApplicantProfileDTO> OnCreateApplicantionAsync(ApplicantProfileDTO applicant);
    }
}
