import re
import os
def test(name):
    print(os.getcwd())
    return os.listdir(name)

ans = test("/home/jingchen/Desktop/huizicsv")
print(ans)
