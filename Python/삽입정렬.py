import random
def inser(arr):
    for i in range(1,len(arr)):
       key = arr[i]
       j=i-1
       while j >= 0 and arr[j] > key:
           arr[j+1] = arr[j]
           j,arr[j+1] = j-1,key
           print("정렬중 : ",arr)

arr = list()
for i in range(10):
    arr.append(random.randint(1,100))
print("처음 리스트 : ",arr)

inser(arr)
print("삽입 정렬 후 리스트 : ",arr)
