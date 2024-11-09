

select CONVERT(sum(tiv_2016),DECIMAL(18, 2)) as tiv_2016 from Insurance aa 
where exists (select bb.pid from Insurance bb where bb.tiv_2015=aa.tiv_2015 and aa.pid!=bb.pid) 
and not exists(select bb.pid from Insurance bb where  aa.pid!=bb.pid and bb.lat=aa.lat and bb.lon=aa.lon)