import cv2
import numpy as np
#np.set_printoptions(threshold=np.inf) # 配列の中身を省略せずに全部表示。     

path_w = "C:\\Users\\frees\\New Unity Project\\Assets\\map.txt"

list_map = np.array([["R","O","R","O","R","O","R","O","R","O","R"],
                     ["O","N","O","N","O","N","O","N","O","N","O"],
                     ["R","O","R","O","R","O","R","O","R","O","R"],
                     ["O","N","O","N","O","N","O","N","O","N","O"],
                     ["R","O","R","O","R","O","R","O","R","O","R"],
                     ["O","N","O","N","O","N","O","N","O","N","O"],
                     ["R","O","R","O","R","O","R","O","R","O","R"],
                     ["O","N","O","N","O","N","O","N","O","N","O"],
                     ["R","O","R","O","R","O","R","O","R","O","R"],
                     ["O","N","O","N","O","N","O","N","O","N","O"],
                     ["R","O","R","O","R","O","R","O","R","O","R"]])
words = ""
#print(list_map)
for y in range(0, list_map.shape[0]):
    if y != 0:
        words += "\n"
    for x in range(0, list_map.shape[1]):
        words += list_map[y,x]
        if x != list_map.shape[1] - 1:
            words += ","

with open(path_w, mode = "w") as f:
    f.write(words)

#print(words)