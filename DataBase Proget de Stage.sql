create database Proget_stage 

use Proget_stage



create table Prospect(code int identity (1,1) primary key , Nom varchar(50) not null,date_creation date ,
Titre varchar(30) , Branche varchar(50) ,  Demarcheure varchar(30) not null, Adresse varchar(70) not null ,Observation  varchar(50) ,
ville varchar(50) , Telephone varchar(30)  ,Profession_Activité varchar(50) ,email varchar(50) )

select * from Prospect

create table Logine(id int identity(1,1) primary key  , Uname varchar(30) not null, passworde varchar(30) not null )

select * from Logine



create table LActionProspection(codeac int identity(1,1) primary key , dateProspection date , codeProc int foreign key  references Prospect(code) ,
sontelephone varchar(30) ,Nom varchar(80), objectDeProspection varchar(50) , moiyenDeContactPreferé varchar(30) ,resultat varchar(30), dateEchance date , 
Persson_inflient varchar(30) , observation varchar(50))
exec sp_rename 'LActionProspection.codP' ,'code','column'

drop table LActionProspection
alter table LActionProspection 
add  Nom varchar(80) 

alter table LActionProspection
drop column Nom


drop table  LActionProspection

select * from LActionProspection

create or alter proc ListeAction
as begin
select dateProspection , Nom , objectDeProspection ,dateEchance , moiyenDeContactPreferé ,Persson_inflient,
sontelephone , resultat  from LActionProspection inner join  Prospect  on  LActionProspection.code = Prospect.code
end
exec ListeAction

create table ListeActions(idAct int identity(1,1) primary key ,
dateProspection date , codeProc int foreign key  references Prospect(code) ,sontelephone varchar(20) ,Nom varchar(80),objectDeProspection varchar(80), moiyenDeContactPreferé varchar(50) , dateEchance date ,
Persson_inflient varchar(50) ,Observation  varchar(50) , Demarcheure varchar(30) ,  resultat varchar(50) ) 

select * from LActionProspection

select * from ListeActions

drop table ListeActions


create table ListeActionsEchan(idAct int identity(1,1) primary key ,
dateProspection date , codeProc int foreign key  references Prospect(code) ,sontelephone varchar(20) ,Nom varchar(80),objectDeProspection varchar(80), moiyenDeContactPreferé varchar(50) , dateEchance date ,
Persson_inflient varchar(50) ,Observation  varchar(50) , Demarcheure varchar(30) ,  resultat varchar(50) ) 

create table ListeActionsprospection(idAct int identity(1,1) primary key ,
dateProspection date , codeProc int foreign key  references Prospect(code) ,sontelephone varchar(20) ,Nom varchar(80),objectDeProspection varchar(80), moiyenDeContactPreferé varchar(50) , dateEchance date ,
Persson_inflient varchar(50) ,Observation  varchar(50) , Demarcheure varchar(30) ,  resultat varchar(50) ) 


SELECT *FROM ListeActions

SELECT idAct, dateProspection, codeProc, sontelephone, Nom, objectDeProspection, moiyenDeContactPreferé, dateEchance, Persson_inflient, Observation, Demarcheure, resultat
FROM   ListeActions
WHERE (dateProspection = '01/01/2022') AND (Demarcheure = 'SAMIR')