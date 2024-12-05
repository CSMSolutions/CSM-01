using DataAccess;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Services.Services
{
    public class AttributeServices
    {
        private readonly GenericRepository<Mau> _mauRepository;
        private readonly GenericRepository<Size> _sizeRepository;

        public AttributeServices()
        {
            _mauRepository = new GenericRepository<Mau>();
            _sizeRepository = new GenericRepository<Size>();
        }

        // Lấy danh sách màu sắc
        public async Task<List<Mau>> GetAllColorsAsync()
        {
            return await _mauRepository.GetAllAsync();
        }

        // Thêm màu sắc mới
        public async Task AddColorAsync(string colorName)
        {
            var newColor = new Mau { MauName = colorName };
            await _mauRepository.InsertAsync(newColor);
        }

        // Cập nhật màu sắc
        public async Task UpdateColorAsync(int colorId, string newColorName)
        {
            var color = await _mauRepository.GetByIdAsync(colorId);
            if (color != null)
            {
                color.MauName = newColorName;
                await _mauRepository.UpdateAsync(color);
            }
            else
            {
                throw new KeyNotFoundException("Màu không tồn tại.");
            }
        }

        // Lấy danh sách kích cỡ
        public async Task<List<Size>> GetAllSizesAsync()
        {
            return await _sizeRepository.GetAllAsync();
        }

        // Thêm kích cỡ mới
        public async Task AddSizeAsync(string sizeName)
        {
            var newSize = new Size { SizeName = sizeName };
            await _sizeRepository.InsertAsync(newSize);
        }

        // Cập nhật kích cỡ
        public async Task UpdateSizeAsync(int sizeId, string newSizeName)
        {
            var size = await _sizeRepository.GetByIdAsync(sizeId);
            if (size != null)
            {
                size.SizeName = newSizeName;
                await _sizeRepository.UpdateAsync(size);
            }
            else
            {
                throw new KeyNotFoundException("Kích cỡ không tồn tại.");
            }
        }
    }
}
