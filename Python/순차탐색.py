import random
def search(arr,key):
    index = 0
    found = False

    while index < len(arr) and not found:
        if arr[index] == key:
            found=True
        else : 
            index+=1

    return found



arr = list()

for i in range(10):
    arr.append(random.randint(1,100))
print("리스트 : ",arr)
key = int(input("찾을 수를 입력하시오 : "))
if search(arr,key):
    print("찾는 값이 있습니다")
else:
    print("찾는 값이 없습니다")


