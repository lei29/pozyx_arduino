import re
import os
import pandas as pd
def getaverage(dirpath):

    expr = r"0x([0-9A-Z]{4})-0x([0-9A-Z]{4})_dist"
    num_of_colums = 0
    num_of_target = 0
    avg_dict = dict()
    all_dict = dict()
    #print(os.getcwd())
    #print(os.listdir(dirpath))
    #os.chdir("/home/jingchen/Desktop")
    for filepath in os.listdir(dirpath):
        print(filepath)
        with open(dirpath+"/"+filepath,"r") as f:
            content = f.readlines()
            #print(content)
            dist_list = []
            list_of_sum = []
            list_of_avg = []
            cnt = 0
            line_num = len(content)
            for line in content:
                line = line.strip()
                if(cnt==0):
                    cnt+=1
                    name_list = line.split(",")
                    num_of_colums = len(name_list)
                    for name in name_list:
                        if(re.match(expr, name)!=None):
                            dist_list.append(name)
                            list_of_sum.append(0)
                            list_of_avg.append(0)
                    num_of_target = len(dist_list)
                    print(dist_list)
                    print(num_of_target)
                else:
                    k = 0

                    num_list = line.split(",")[1:]
                    print(num_list)
                    for num in num_list:
                        if(num == "" or num ==" " or num == "  "):
                            num_list[k] = 0
                        k+=1
                    num_list =list(map(float,num_list))
                    #print("num_list")
                    #print(len(num_list))
                    i = num_of_target
                    while(i>0):
                        list_of_sum[num_of_target-i] = list_of_sum[num_of_target-i]+int(num_list[num_of_colums-1-i])
                        #print(str(i)+" "+str(num_of_target-i) + " " +str(num_of_colums-1-i))
                        i-=1
        i = num_of_target-1
        while(i>=0):
            list_of_avg[i] = list_of_sum[i]/line_num
            avg_dict[dist_list[i]] = list_of_avg[i]
            i-=1
        all_dict[filepath] = avg_dict
    return all_dict

def tocsv(dirpath):
    print(os.listdir(dirpath))
    for file in os.listdir(dirpath):
        print(file)
        data_xls = pd.read_excel(dirpath+"/"+file,'Simple Data', index_col=None)
        data_xls.to_csv(file[:-5]+".csv", encoding="utf-8",index=False)



lsit = getaverage("/home/jingchen/Desktop/huizicsv")
print(lsit)
'''
tocsv("/home/jingchen/Desktop/huizicsv/ACTS")
'''
{'3T8U.txt': {'0x6704-0x6765_dist': 4156.007359705612, '0x6749-0x6765_dist': 4911.291628334867, '0x6749-0x6704_dist': 3310.0423183072676},
 'UOPX.txt': {'0x6704-0x6765_dist': 4156.007359705612, '0x6749-0x6765_dist': 4911.291628334867, '0x6749-0x6704_dist': 3310.0423183072676},
 'ROLB.txt': {'0x6704-0x6765_dist': 4156.007359705612, '0x6749-0x6765_dist': 4911.291628334867, '0x6749-0x6704_dist': 3310.0423183072676},
 'L2GO.txt': {'0x6704-0x6765_dist': 4156.007359705612, '0x6749-0x6765_dist': 4911.291628334867, '0x6749-0x6704_dist': 3310.0423183072676},
 'UG8W.txt': {'0x6704-0x6765_dist': 4156.007359705612, '0x6749-0x6765_dist': 4911.291628334867, '0x6749-0x6704_dist': 3310.0423183072676},
 'XZH5.txt': {'0x6704-0x6765_dist': 4156.007359705612, '0x6749-0x6765_dist': 4911.291628334867, '0x6749-0x6704_dist': 3310.0423183072676},
 '52AF.txt': {'0x6704-0x6765_dist': 4156.007359705612, '0x6749-0x6765_dist': 4911.291628334867, '0x6749-0x6704_dist': 3310.0423183072676},
 'EXCE.txt': {'0x6704-0x6765_dist': 4156.007359705612, '0x6749-0x6765_dist': 4911.291628334867, '0x6749-0x6704_dist': 3310.0423183072676},
 'XFD8.txt': {'0x6704-0x6765_dist': 4156.007359705612, '0x6749-0x6765_dist': 4911.291628334867, '0x6749-0x6704_dist': 3310.0423183072676},
 '076E.txt': {'0x6704-0x6765_dist': 4156.007359705612, '0x6749-0x6765_dist': 4911.291628334867, '0x6749-0x6704_dist': 3310.0423183072676},
 'VTAY.txt': {'0x6704-0x6765_dist': 4156.007359705612, '0x6749-0x6765_dist': 4911.291628334867, '0x6749-0x6704_dist': 3310.0423183072676},
 'M6B2.txt': {'0x6704-0x6765_dist': 4156.007359705612, '0x6749-0x6765_dist': 4911.291628334867, '0x6749-0x6704_dist': 3310.0423183072676}}
