Họ tên: Huỳnh Quốc Hưng
MSSV: 3121410239
Project: Webite bán sách

*CÁCH CÀI ĐẶT PROJECT:
B1: Mở Microsoft SQL Server kết nối và sao chép Server name
![image](https://github.com/user-attachments/assets/ee5b6775-2628-466d-929e-6c4f6e58ebf5)

B2: Trong thanh tìm kiếm của window gõ: edit environment variables for your account và thêm biến môi trường với tên biến là DB_SERVER và giá trị là tên của server (Server name)
![image](https://github.com/user-attachments/assets/4868416a-a327-4876-8c87-f2170342729a)
![image](https://github.com/user-attachments/assets/ab77c1ab-3d51-4653-9708-df9fea492bc7)

B3: Mở project và nhấp vào Tools -> NuGet Package Manager -> Package Manager Console
![462578783_487452403787140_3719223035962740916_n](https://github.com/user-attachments/assets/b5fba1b4-3b15-449e-bd55-3a1a40cf9afd)

B4: Gõ update-database để khởi tạo cơ sở dữ liệu mặc định
B5: Bấm F5 chạy project sẽ khởi tạo sẵn tài khoản admin trong database

email: admin@gmail.com
password: Admin123*

*CÁC CHỨC NĂNG:
- Quản lý đơn đặt hàng
- Xem chi tiết sản phẩm
- Quản lý thông tin: thể loại, sách, doanh nghiệp, người dùng
- (Admin) tạo tài khoản cho nhân viên, doanh nghiệp và người dùng hoặc người dùng có thể tự đăng ký
