import re
import os
import pandas as pd
def getaverage(dirpath):

    expr = r"0x([0-9A-Z]{4})-0x([0-9A-Z]{4})_dist"
    num_of_colums = 0
    num_of_target = 0

    all_dict = dict()
    #print(os.getcwd())
    #print(os.listdir(dirpath))
    #os.chdir("/home/jingchen/Desktop")
    for filepath in os.listdir(dirpath):
        #print(filepath)
        with open(dirpath+"/"+filepath,"r") as f:
            content = f.readlines()
            #print(content)
            dist_list = []
            list_of_sum = []
            list_of_avg = []
            avg_dict = dict()
            cnt = 0
            line_num = len(content) -1
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
                    #print(dist_list)
                    #print(num_of_target)
                else:
                    k = 0

                    num_list = line.split(",")[1:]
                    #print(num_list)
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


{'3T8U.txt': {'0x6704-0x6765_dist': 3985.250200481155, '0x6749-0x6765_dist': 4716.085805934242, '0x6749-0x6704_dist': 3480.84202085004},
 'UOPX.txt': {'0x6704-0x6765_dist': 3135.3644859813085, '0x6749-0x6765_dist': 4593.353805073431, '0x6749-0x6704_dist': 3287.8945260347127},
 'ROLB.txt': {'0x6704-0x6765_dist': 3215.135888501742, '0x6749-0x6765_dist': 4862.875725900116, '0x6749-0x6704_dist': 3782.0708478513357},
 'L2GO.txt': {'0x6704-0x6765_dist': 3797.991452991453, '0x6749-0x6765_dist': 4679.154795821462, '0x6749-0x6704_dist': 3445.0892687559353},
 'UG8W.txt': {'0x6704-0x6765_dist': 4517.156293222683, '0x6749-0x6765_dist': 4893.349930843707, '0x6749-0x6704_dist': 3623.2759336099584},
 'XZH5.txt': {'0x6704-0x6765_dist': 4059.675213675214, '0x6749-0x6765_dist': 5053.46628679962, '0x6749-0x6704_dist': 3468.908831908832},
 '52AF.txt': {'0x6704-0x6765_dist': 2949.740592473979, '0x6749-0x6765_dist': 4701.752602081665, '0x6749-0x6704_dist': 3526.127301841473},
 'EXCE.txt': {'0x6704-0x6765_dist': 3790.1287272727272, '0x6749-0x6765_dist': 4814.397090909091, '0x6749-0x6704_dist': 3613.2814545454544},
 'XFD8.txt': {'0x6704-0x6765_dist': 3407.445925925926, '0x6749-0x6765_dist': 4791.102962962963, '0x6749-0x6704_dist': 3486.9607407407407},
 '076E.txt': {'0x6704-0x6765_dist': 4156.378820960698, '0x6749-0x6765_dist': 4763.921397379912, '0x6749-0x6704_dist': 3447.4486899563317},
 'VTAY.txt': {'0x6704-0x6765_dist': 4044.813419117647, '0x6749-0x6765_dist': 5129.809742647059, '0x6749-0x6704_dist': 3329.172794117647},
 'M6B2.txt': {'0x6704-0x6765_dist': 4159.834254143647, '0x6749-0x6765_dist': 4915.813996316759, '0x6749-0x6704_dist': 3313.0902394106815}}
'''
