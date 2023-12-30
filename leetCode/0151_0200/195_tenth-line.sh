


# awk，当处理到第10行时，打印该行。NR表示awk处理的当前行号。
awk 'NR == 10' file.txt


#tail+head，使用tail命令输出文件的第10行及之后的所有行，然后将结果通过管道传递给head命令。head命令只保留第一行并将其作为输出。
tail -n +10 file.txt | head -1

#
#
#sed，-n选项取消sed默认的输出，'10p'指定只打印第10行。
sed -n '10p' file.txt