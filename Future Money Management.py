"""Future Money Management"""
def purpose_of_user():
    """Future Money Management"""
    purpose = input("Purpose : ") # จุดประสงค์ว่าเราต้องการคำนวณหาว่าต้องใช้เวลากี่วัน หรือต้องเก็บเงินวันละเท่าไร จึงจะได้จำนวนเงินที่ต้องการจะเก็บ
    amount_to_collect = int(input("Amount to collect : "))
    if purpose == "daily": # เมื่อกำหนดจุดประสงค์เป็น daily คือต้องการหาว่าต้องเก็บเงินวันละเท่าไร
        daily(amount_to_collect)
    elif purpose == "time": # เมื่อกำหนดจุดประสงค์เป็น time คือต้องการคำนวณหาว่าต้องใช้เวลากี่วัน
        time(amount_to_collect)
    else:
        "Wrong!!"

def time(amount_to_collect):
    """Calculate time required to collect money""" # คำนวณเงินที่ต้องการจะเก็บในอนาคต โดยการคำนวณว่าต้องใช้เวลาประมาณเท่าไรถึงจะได้เงินตามจำนวนที่ต้องการ
    daily_amount_to_collect = int(input("Daily amount to collect : ")) # จำนวนเงินที่เก็บในแต่ละวัน
    if amount_to_collect > 0 and daily_amount_to_collect > 0:
        day = amount_to_collect // daily_amount_to_collect
        year = day // 365
        yearmodday = day % 365
        month = yearmodday // 30
        monthmodday = yearmodday % 30
        print("About %d Year %d Month %d Day."%(year, month, monthmodday))
    else: # เมื่อใส่ข้อมูลผิดพลาดอย่างเช่น เงินติดลบ ก็จะขึ้นข้อความว่า Wrong!! เพื่อแสดงถึงข้อมูลที่ผิดพลาด
        print("Wrong!!")

def daily(amount_to_collect):
    """Calculate daily amount to collect""" # คำนวณเงินที่ต้องการจะเก็บในอนาคต โดยการคำนวณว่าควรใช้เงินกี่บาทต่อวัน
    number_of_the_day = int(input("Time required to collect money (day) : ")) # ระยะเวลาที่ต้องการจะเก็บ(วัน)
    if amount_to_collect > 0 and number_of_the_day > 0:
        print("Should be collect %d Baht per day"%(amount_to_collect//number_of_the_day))
    else: # เมื่อใส่ข้อมูลผิดพลาดอย่างเช่น เงินติดลบ ก็จะขึ้นข้อความว่า Wrong!! เพื่อแสดงถึงข้อมูลที่ผิดพลาด
        print("Wrong!!")

purpose_of_user()
