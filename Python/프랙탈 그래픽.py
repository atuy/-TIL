import turtle

def draw(br,t):
    if br > 5:
        t.forward(br)
        t.right(20)
        draw(br-15,t)
        t.left(40)
        draw(br-15,t)
        t.right(20)
        t.backward(br)


t = turtle.Turtle()
win=turtle.Screen()
t.left(90)
t.up()
t.backward(200)
t.down()
t.color("green")
draw(100,t)

