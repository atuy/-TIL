import random

def inser(arr):
    for i in range(1,len(arr)):
       key = arr[i]
       j=i-1
       while j >= 0 and arr[j] > key:
           arr[j+1] = arr[j]
           j,arr[j+1] = j-1,key
           print("정렬중 : ",arr)

def search_bi(arr,key):
    low=0
    top = len(arr)-1
    while low <=top:
        middle = (low+top)//2
        print("low = ",arr[low],"\tmiddle = ",arr[middle],"\ttop = ",arr[top])
        if arr[middle] > key:
            top = middle-1
        elif arr[middle] < key:
            low = middle+1
        else:
            return middle

arr = list()
for i in range(10):
    arr.append(random.randint(1,100))
print("처음 리스트 : ",arr)

inser(arr)
print("삽입 정렬 후 리스트 : ",arr)
key = int(input("찾을 수를 입력하시오 : "))
if search_bi(arr,key):
    print("찾는 값이 있습니다")
else:
    print("찾는 값이 없습니다")




