using DataAccess;
using Models;
using Services.ModelViews.LoginModelViews;

namespace Services
{
    public class LoginService
    {
        private readonly GenericRepository<NguoiDung> _nguoiDungRepository;

        public LoginService()
        {
            _nguoiDungRepository = new();
        }

        public async Task<bool> Login(LoginRequest request)
        {
            NguoiDung? nguoiDung
                = await _nguoiDungRepository.FindAsync(x => x.TenDangNhap == request.Username && x.MatKhau == request.Password);
            return nguoiDung is not null;
        }
    }
}
