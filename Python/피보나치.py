def fibo(n):
    if n==0:
        return 0
    elif n==1:
        return 1
    else:
        return fibo(n-1)+fibo(n-2)

n = int(input("수를 입력하시오 : "))
print(n, "번쨰 피보나치 수는 ",fibo(n))
