
#先确定文件总共有多少列, 然后逐列提取内容, 将每一列用空格连接为一行.

# 获取列数
COLUMNS=$(head -n 1 file.txt| wc -w)

for i in $(seq 1 $COLUMNS); do
    # 获取第i列，然后用paste合并
    cut -d ' ' -f"$i" file.txt | paste -s -d' ' -
done

####################

columns=$(cat file.txt | head -n 1 | wc -w)
for i in $(seq 1 $columns)
do
awk '{print $'''$i'''}' file.txt | xargs
done



####
awk '{
    for (i=1;i<=NF;i++){
        if (NR==1){
            res[i]=$i
        }
        else{
            res[i]=res[i]" "$i
        }
    }
}END{
    for(j=1;j<=NF;j++){
        print res[j]
    }
}' file.txt