using DataAccess;
using Microsoft.EntityFrameworkCore;
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
                = await _nguoiDungRepository.Entities.FirstOrDefaultAsync(x => x.TenDangNhap == request.Username && x.MatKhau == request.Password && x.VaiTro == "admin");
            return nguoiDung is not null;
        }
    }
}
