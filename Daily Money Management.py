"""Daily Money Management"""
def money(money_now, day_now, month): # กำหนดเงินปัจจุบัน, วันที่ ณ ปัจจุบัน, เดือน ณ ปัจจุบัน ตามลำดับ
    """Calculate money each day""" # คำนวณหาว่าควรใช้เงินวันละเท่าไร จึงจะพอใช้ถึงสิ้นเดือน
    if month in ["1", "3", "5", "7", "8", "10", "12"] and 1 <= day_now <= 31: #คำนวณเงินจากเดือนที่ลงท้ายด้วย "คม"
        print("Money that should be spent each day : %d Baht"%(money_now//((31-day_now)+1)))
    elif month in ["4", "6", "9", "11"] and 1 <= day_now <= 30: #คำนวณเงินจากเดือนที่ลงท้ายด้วย "ยน"
        print("Money that should be spent each day : %d Baht"%(money_now//((30-day_now)+1)))
    elif month == "February" or month == "2" and 1 <= day_now <= 28: #คำนวณเงินจากเดือนกุมภาพันธ์
        print("Money that should be spent each day : %d Baht"%(money_now//((28-day_now)+1)))
    else: #เมื่อใส่ข้อมูลผิดพลาดอย่างเช่น ใส่เงินติดลบ หรือใส่เดือนที่ไม่มีอยู่จริง หรือใส่วันที่ไม่มีอยู่จริงหรือเกินเดือนนั้นๆ ก็จะขึ้นว่า "Wrong!!" เพื่อแสดงให้รู้ว่าข้อมูลผิดพลาด
        print("Wrong!")
money(int(input("Money : ")), int(input("Date : ")), input("Month : "))
