

select patient_id, patient_name, conditions from Patients  where LOCATE(' DIAB1',conditions)>0 or conditions like 'DIAB1%'