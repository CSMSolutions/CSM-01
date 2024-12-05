using DataAccess;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CategoryService
    {
        private readonly GenericRepository<DanhMuc> danhMucRepo;

        public CategoryService()
        {
            danhMucRepo = new GenericRepository<DanhMuc>();
        }

        public List<ResponseDanhMuc> GetAll()
        {
            return danhMucRepo.Entities.Select(_ => new ResponseDanhMuc() { ID = _.DanhMucId, TenDanhMuc = _.TenDanhMuc})
                .ToList();
        }

        public List<ResponseDanhMuc> Search(string searchText)
        {
            return danhMucRepo.Entities.Where(_ => _.TenDanhMuc.Contains(searchText))
                .Select(_ => new ResponseDanhMuc() { ID = _.DanhMucId, TenDanhMuc = _.TenDanhMuc })
                .ToList();
        }

        public void Add(string tenDanhMuc)
        {
            bool existed = danhMucRepo.Entities.Any(_ => _.TenDanhMuc == tenDanhMuc);
            if(existed)
            {
                throw new Exception("Danh mục đã tồn tại");
            }
            DanhMuc danhMuc = new() { TenDanhMuc = tenDanhMuc };

            danhMucRepo.Insert(danhMuc);
        }
    }

    public class ResponseDanhMuc
    {
        public int ID { get; set; }
        public string TenDanhMuc { get; set; } = null!;
    }
}
