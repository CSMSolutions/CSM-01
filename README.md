# Thành viên
<h4>Tên nhóm: CSM  </h4>
  
| STT | Họ tên | Chức vụ  |
|----------------|--------------------|--------------------|
|  1  |  Trần Thế Ngọc Mai  |   Nhóm trưởng  |
|  2  |  Lê Hoàng Quân      |   Thành viên   |
|  3  |  La Khả Văn	    |   Thành viên   |
-----------------------------------------------
### Sử dụng 
 - .Net Framework version 8.0
 - Visual studio 2022
 - Sql Server 2020
-----------------------------------------------
# Dự án

## Phần mềm quản lý shop quần áo

<h5>Mô tả dự án: </h5>
<p>Dự án "Clothing Shop Manager (CSM)" là một ứng dụng quản lý cửa hàng quần áo, nhằm cung cấp cho các chủ cửa hàng một giải pháp quản lý hiệu quả và dễ sử dụng. Mục tiêu của dự án là giúp các cửa hàng thời trang theo dõi sản phẩm, quản lý đơn hàng, chăm sóc khách hàng, và tối ưu hóa doanh thu thông qua các công cụ báo cáo và thống kê.</p>

### Yêu cầu 
<p>AI: ChatBot hỗ trợ mua hàng  </p>

<p>Web: MVC ASP, LinQ</p>
<p>Ngôn ngữ: Javascript, C# </p>
<p>Framework: Bootstrap, Tailwind CSS</p>

<p>Nghiệp vụ</p>

| STT | Công việc | Phân công  |
|----------------|--------------------|--------------------|
|  1  |  Đăng ký đăng nhập  | Mai |
|  2  |  Tìm kiếm sản phẩm |  Mai |
|  3  |  Hiển thị danh sách sản phẩm, chi tiết sản phẩm | Mai |
|  4  |  Sắp xếp, lọc sản phẩm | Mai |
|  5  |  CRUD giỏ hàng | Mai |
|  6  |  Thanh toán | Mai |
|  7  |  Đánh giá sản phẩm | Mai |
|  8  |  Xem đơn hàng | Văn |
|  9  |  Xem lịch sử mua hàng | Quân |
|  10  |  KNN(AI) | Mai |




<p>App: Winform </p>
<p>Ngôn ngữ: C# </p>

| STT | Công việc | Phân công  |
|----------------|--------------------|--------------------|
|  1  |  Đăng nhập/đăng xuất | Văn  |
|  2  |  Quản lý người dùng [CRUD người dùng] | Văn |
|  3  |  Quản lý sản phẩm [CRUD sản phẩm] | Văn |
|  4  |  Quản lý danh mục [CRUD danh mục] | Văn |
|  5  |  Quản lý size [CRUD size] | Quân |
|  6  |  Quản lý màu [CRUD màu] | Quân |
|  7  |  Thống kế/ báo cáo, xuất file  | Quân |
|  8  |  Quản lý đơn hàng [CRUD đơn hàng]| Quân |
|  9  |  Tìm kiếm/ phân trang  | Mai |

# Chức năng

## Ứng dụng "Clothing Shop Manager (CSM)"

### Tìm kiếm quần áo / Sắp xếp:
- Tìm kiếm quần áo theo tên, thương hiệu, màu sắc, kích thước, v.v.
- Sắp xếp theo giá, tên sản phẩm hoặc thương hiệu.
- Hiển thị danh sách sản phẩm phù hợp với tiêu chí tìm kiếm hoặc sắp xếp.

### Đăng nhập / Đăng ký:
- Người dùng tạo tài khoản mới hoặc đăng nhập vào hệ thống bằng tài khoản đã có.
- Xác thực thông tin đăng nhập và cung cấp chức năng quên mật khẩu.
- Phân quyền người dùng: Quản trị viên và khách hàng.

### Xem thông tin quần áo:
- Hiển thị danh sách sản phẩm quần áo trên trang chủ và trang sản phẩm.
- Cung cấp bộ lọc để thu hẹp kết quả tìm kiếm theo danh mục, thương hiệu, và các đặc tính khác.
- Xem chi tiết từng sản phẩm, bao gồm mô tả, giá cả, hình ảnh và đánh giá của người dùng.
- Xem chi tiết đơn hàng bao gồm trạng thái và thông tin giao hàng.

### Quản lý người dùng (Cập nhật hồ sơ cá nhân):
- Người dùng cập nhật thông tin cá nhân bao gồm tên, email, số điện thoại, địa chỉ.
- Đổi mật khẩu và quản lý các thiết lập bảo mật của tài khoản.

### Quản lý đơn hàng / Thanh toán:
- Hiển thị thông tin chi tiết về các đơn hàng đã đặt, bao gồm mã đơn hàng, trạng thái và lịch sử giao dịch.
- Cung cấp các tùy chọn thanh toán: thẻ tín dụng, ví điện tử, hoặc tiền mặt khi nhận hàng.
- Người dùng có thể hủy đơn hàng trước khi đơn hàng được xử lý.

### Đánh giá sản phẩm:
- Người dùng có thể để lại đánh giá, xếp hạng sản phẩm và bình luận về các sản phẩm đã mua.
- Hiển thị các đánh giá của người dùng khác cho từng sản phẩm.

---

## Ứng dụng quản trị (Quản lý cửa hàng)

### Đăng nhập / Đăng xuất:
- Quản trị viên đăng nhập để truy cập các chức năng quản lý.
- Đăng xuất để kết thúc phiên làm việc một cách an toàn.

### Quản lý người dùng (CRUD người dùng):
- Quản trị viên có thể thêm mới, chỉnh sửa hoặc xóa người dùng.
- Hiển thị danh sách tất cả người dùng bao gồm quyền hạn và thông tin tài khoản.

### Quản lý sản phẩm + AI (CRUD thương hiệu và sản phẩm):
- Quản lý thông tin thương hiệu: thêm mới, chỉnh sửa hoặc xóa thương hiệu.
- Quản lý danh mục sản phẩm: thêm mới, chỉnh sửa hoặc xóa sản phẩm, cập nhật giá cả và số lượng tồn kho.
- Ứng dụng AI ChatBot hỗ trợ mua hàng.

### Thống kê / Báo cáo:
- Hiển thị báo cáo doanh thu theo ngày, tuần, tháng hoặc năm.
- Thống kê sản phẩm bán chạy, khách hàng trung thành và các xu hướng bán hàng.
- Tạo báo cáo tùy chỉnh theo yêu cầu của quản trị viên.

### Quản lý đơn hàng / Thanh toán:
- Quản lý toàn bộ đơn hàng của hệ thống, bao gồm theo dõi trạng thái đơn hàng, xử lý đơn hàng và kiểm tra thông tin thanh toán.
- Cung cấp công cụ kiểm tra giao dịch và xác minh thanh toán cho quản trị viên.
