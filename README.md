# SumFactorial
Ứng dụng kiểm tra số nguyên tố

**Mục tiêu**

Luyện tập sử dụng hàm đệ quy.

**Mô tả**

Trong phần này, chúng ta sẽ phát triển một ứng dụng để tính giá trị giai thừa.

Công thức tính giai thừa là như sau: 

**n! = n * (n - 1)**

**0! = 1**

**Hướng dẫn**
 - Đầu tiên chúng ta xác định yêu cầu bài toán:
   - Ứng dụng cho phép nhập vào 1 số và tính giai thừa của nó.
 - Phân tích:
   - Công thức tính giai thừa n! = n * (n - 1), với 0! = 1.
 - Cách giải:
   - Viết code tính giai thừa của số theo thuật toán đệ quy.
   - Viết code đọc dữ liệu từ bàn phím.
 - Chi tiết:
    - Viết code đọc dữ liệu số nhập từ bàn phím.
    - Viết hàm tính giai thừa
      - Tham số đầu vào là i kiểu int
      - Kiểm tra i nếu n <=1 thì return về 1
      - Nếu i != 1 thì
      - Giảm i đi 1 đơn vị và gán cho biến n: n = i - 1
      - Gọi hàm tính giai thừa với tham số là n
      - Trả về kết quả cuối cùng
   - Không hợp lệ: Thông báo

