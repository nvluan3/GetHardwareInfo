Ứng dụng nhỏ dùng để thu thập và xuất thông tin phần cứng/máy tính trên Windows.

**Mục đích**
- Hiển thị thông tin hệ thống (nhà sản xuất, model, BIOS, hệ điều hành).
- Hiển thị thông tin CPU, GPU, RAM (các khe, dung lượng), và ổ lưu trữ.
- Xuất báo cáo dưới dạng file `.txt` và copy nội dung vào clipboard.

**Tính năng chính**
- Hiển thị Header: `ComputerName | UserName | IP`.
- Machine info: Manufacturer, Model, Service Tag, BIOS, OS.
- CPU: Tên, số nhân/số luồng.
- GPU: Tên và dung lượng bộ nhớ (nếu có).
- RAM: Tổng dung lượng, danh sách thanh RAM (Device Locator, dung lượng, tốc độ, nhà sản xuất), hiển thị số khe còn trống.
- Storage: Danh sách ổ cứng/SSD (model, serial, dung lượng).
- Nút xuất file: tạo file `\<ComputerName\>.txt` trong thư mục chứa executable và mở Explorer để chọn file.
- Nút copy: copy toàn bộ báo cáo vào Clipboard.