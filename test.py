import numpy as np
import cv2
import base64
import cv2
import PIL as p
import time as t

cap = cv2.VideoCapture(1)

while 1:
    ret, frame = cap.read()
    print(ret)
    cv2.imshow("Main", frame)
    print(frame)
    t.sleep(2)

