import random
def sel(arr):
    for i in range(0,len(arr)-1):
        min_index=i
        for j in range(i+1,len(arr)):
            if arr[j] < arr[min_index]:
                min_index=j
        arr[i], arr[min_index] = arr[min_index],arr[i]
        print("정렬중",arr)

arr = list()
for i in range(10):
    arr.append(random.randint(1,100))
print("처음 리스트 : ",arr)

sel(arr)
print("선택 정렬 후 리스트 : ",arr)
