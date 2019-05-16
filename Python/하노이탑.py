def hanoi(n,start,tmp,end):
    if n==1:
        print("원판 1을", start,"에서",end,"로 옮긴다")
    else:
        hanoi(n-1,start,tmp,end)
        print("원판",n,"을", start,"에서",end,"로 옮긴다")
        hanoi(n-1,tmp,start,end)

hanoi(4,'a','b','c')
