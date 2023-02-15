CREATE DATABASE gestionCongres;
USE gestionCongres;

/* Création d'un user */
CREATE LOGIN GestOrgaCongres WITH PASSWORD = 'Gest0rg@C0ngrès**';
CREATE USER GestOrgaCongres FOR LOGIN GestOrgaCongres;

/* Attribution des droits à l'utilisateur */
GRANT SELECT,INSERT,DELETE,UPDATE ON HOTEL TO GestOrgaCongres;
GRANT SELECT,INSERT,DELETE,UPDATE ON SESSION TO GestOrgaCongres;
GRANT SELECT,INSERT,DELETE,UPDATE ON ACTIVITE TO GestOrgaCongres;
GRANT SELECT,INSERT,DELETE,UPDATE ON CONGRESSISTE TO GestOrgaCongres;
GRANT SELECT,INSERT,DELETE ON PARTICIPER TO GestOrgaCongres;
GRANT SELECT,INSERT,DELETE ON INSCRIRE TO GestOrgaCongres;

/* Création des tables */

CREATE TABLE Salle(
	idSalle INT NOT NULL IDENTITY, 
	nomSalle VARCHAR(10) NOT NULL,
	CONSTRAINT pk_salle PRIMARY KEY (idSalle)
);

CREATE TABLE Session(
	numSession INT NOT NULL IDENTITY,
	theme VARCHAR(150) NOT NULL,
	heureDebut TIME NOT NULL,
	date DATE NOT NULL,
	nbPlacesMax INT NOT NULL,
	prix DECIMAL(10,2) NOT NULL,
	nomPresident VARCHAR(50) NOT NULL,
	idSalle INT NOT NULL,
	CONSTRAINT pk_session PRIMARY KEY (numSession),
	CONSTRAINT fk_session_salle FOREIGN KEY (idSalle) REFERENCES SALLE(idSalle)
);
 
CREATE TABLE Activite(
	idActivite INT NOT NULL IDENTITY,
	designation VARCHAR(150) NOT NULL,
	prix DECIMAL(10,2) NOT NULL,
	date DATE NOT NULL,
	heureDebut TIME NOT NULL,
	nbPlacesMax INT NOT NULL,
	CONSTRAINT pk_activite PRIMARY KEY (idActivite)
);

CREATE TABLE Categorie(
	idCateg INT NOT NULL IDENTITY,
	nbEtoiles INT NOT NULL,
	CONSTRAINT pk_categorie PRIMARY KEY (idCateg)
);

CREATE TABLE Hotel(
	idHotel INT NOT NULL IDENTITY,
	nom VARCHAR(50) NOT NULL,
	adresse VARCHAR(100) NOT NULL,
	cp CHAR(5) NOT NULL,
	ville VARCHAR(50) NOT NULL,
	tel CHAR(10) NOT NULL,
	prixChambre DECIMAL(10,2) NOT NULL,
	idCateg INT NOT NULL,
	CONSTRAINT pk_hotel PRIMARY KEY (idHotel),
	CONSTRAINT fk_hotel_categorie FOREIGN KEY (idCateg) REFERENCES Categorie(idCateg)
);

CREATE TABLE Ligue(
	idLigue INT NOT NULL IDENTITY,
	nomLigue VARCHAR(50) NOT NULL,
	adresse VARCHAR(100) NOT NULL,
	cp CHAR(5) NOT NULL,
	ville VARCHAR(50) NOT NULL,
	CONSTRAINT pk_ligue PRIMARY KEY (idLigue)
);

CREATE TABLE Congressiste(
	numInscription INT NOT NULL IDENTITY,
	nom VARCHAR(50) NOT NULL,
	prenom VARCHAR(50) NOT NULL,
	adresse VARCHAR(100) NOT NULL,
	cp CHAR(5) NOT NULL,
	ville VARCHAR(50) NOT NULL,
	tel CHAR(10) NOT NULL,
	acompte DECIMAL(10,2) NOT NULL,
	idHotel INT NOT NULL,
	idLigue INT NOT NULL,
	CONSTRAINT pk_congressiste PRIMARY KEY (numInscription),
	CONSTRAINT fk_congressiste_hotel FOREIGN KEY (idHotel) REFERENCES Hotel(idHotel),
	CONSTRAINT fk_congressiste_ligue FOREIGN KEY (idLigue) REFERENCES Ligue(idLigue)
);

CREATE TABLE Inscrire(
	idActivite INT NOT NULL,
	numInscription INT NOT NULL,
	CONSTRAINT pk_inscrire PRIMARY KEY (idActivite, numInscription),
	CONSTRAINT fk_inscrire_activite FOREIGN KEY (idActivite) REFERENCES Activite(idActivite),
	CONSTRAINT fk_inscrire_congressiste FOREIGN KEY (numInscription) REFERENCES Congressiste(numInscription)
);

CREATE TABLE Participer(
	numSession INT NOT NULL,
	numInscription INT NOT NULL,
	CONSTRAINT pk_participer PRIMARY KEY (numSession, numInscription),
	CONSTRAINT fk_participer_session FOREIGN KEY (numSession) REFERENCES Session(numSession),
	CONSTRAINT fk_participer_congressiste FOREIGN KEY (numInscription) REFERENCES Congressiste(numInscription)
);

/* Création du jeu d'essai */
INSERT INTO Categorie (nbEtoiles) VALUES (1), (2), (3);

INSERT INTO Hotel (nom, adresse, cp, ville, tel, prixChambre, idCateg) VALUES
				  ('Au bel Horizon', '15 rue du Papier', '54000','Nancy', '0454545454', 75.50, 2),
				  ('Campanile', '3 impasse du Chemin Vert', '54000', 'Nancy', '0401020304', 40.00, 1),
				  ('Dors bien ici', '43 avenue du Faubourg', '54000', 'Nancy', '0467626762', 104.00, 3), 
				  ('Au Nancy Hôtel', '14 chemin de la Rue', '54000', 'Nancy', '0490909090', 50.00, 1), 
				  ('Le Lit Douillet', '2 Boulevard Guérin', '54000', 'Nancy', '0456765767', 80.00, 3), 
				  ('L''Oreiller Moelleux', '5 rue Prévert', '54000', 'Nancy', '0434343434', 70.00, 2), 
                  ('Hôtel du Centre', '6 place du Centre', '54000', 'Nancy', '0413233445', 90.00, 3), 
                  ('Plumeau Plume', '2 route du Piaf', '54000', 'Nancy', '040122133', 45.00, 1),
                  ('Ô la belle Vue !', '3 avenue du Cimetière', '54000', 'Nancy', '046579488', 65.00, 2), 
				  ('La Chambre Forte', '6 chemin du Château', '54000', 'Nancy', '0458338599', 80.00, 3);

INSERT INTO SALLE (nomSalle) VALUES ('Salle 101'),('Salle 102'),('Salle 103'),('Salle 104'),('Salle 105');
INSERT INTO SESSION (theme, heureDebut, date, nbPlacesMax, prix, nomPresident, idSalle) VALUES 
					('Session d''inauguration','09:00','17/06/2023',30,5,'Mendes',1),
					('Pratique sportive chez le diabétique de type 1','14:30','17/06/2023',10,20,'Dufour',1),
					('Jambe douloureuse du sportif','14:30','17/06/2023',15,15,'Garcia',2),
					('Valvulopathies du sportif','14:30','17/06/2023',25,10,'Leblanc',3),
					('Symposium lipides et sport','14:30','17/06/2023',5,25,'Aubert',4),
					('Evaluation psychologique du sportif','14:30','17/06/2023',20,15,'Martin',5),
					('Comment optimiser la performance ?','9:00','18/06/2023',20,20,'Mendes',1),
					('Entrainement en altitude et stress thermique','9:00','18/06/2023',15,10,'Garcia',2),
					('Hydratation autour d''épreuve sportive','9:00','18/06/2023',10,5,'Dufour',3),
					('Utilité de l''oxygène dans la récupération et la performance','9:00','18/06/2023',5,10,'Aubert',4),
					('Traumatologie du sport','9:00','18/06/2023',25,20,'Martin',5),
					('Pratiques sportives et usages de drogues','14:30','18/06/2023',30,25,'Leblanc',3),
					('Le burnout sportif comparé au syndrome de surentraînement','9:00','20/06/2023',10,30,'Durant',4),
					('Psychologie du sportif','9:00','20/06/2023',15,25,'Leblanc',3),
					('Laser en médecine du sport','14:30','20/06/2023',20,20,'Aubert',5),
					('L''autoévaluation des habitudes nutritionnelles','14:30','20/06/2023',25,20,'Mendes',3),
					('Quel contrôle médical préalable à la pratique sportive à l’étranger ?','09:00','21/06/2023',25,10,'Dufour',4),
					('Session de fermeture','14:30','21/06/2023',20,15,'Garcia',2);
					
INSERT INTO LIGUE (nomLigue, adresse, cp, ville) VALUES 
				  ('Ligue Lorraine de Tennis','Maison Régionale des Sports de Lorraine 13 Rue Jean Moulin',54510,'Tomblaine'),
				  ('Ligue Football Occitanie','615 Avenue Dr Jacques Fourcade',34000,'Montpellier'),
				  ('Ligue des Pays de la Loire de Basket Ball','2 Rue Paul Gauguin',44800,'Saint-Herblain'),
				  ('Ligue de Bretagne de Judo','1 Allée Pierre de Coubertin',35200,'Rennes'),
				  ('Ligue de Golf Occitanie','5 Allée du Golf',31200,'Toulouse'),
				  ('Ligue Provence Alpes Côte d''Azur Handball','30 Avenue Henri Matisse','06200','Le Minotaure'),
				  ('Ligue PACA de Natation','10 Rue de la République',13001,'Marseille'),
				  ('Ligue Régionale de Bretagne Karaté','2 Boulevard Viollard',56300,'Pontivy'),
				  ('Ligue Occitanie de Rugby à XIII','7 Rue André Citroën',31130,'Balma'),
				  ('Ligue d''Escrime de l''Académie de Paris','4 Rue du Général Humbert',75014,'Paris');
		  
INSERT INTO CONGRESSISTE(nom, prenom, adresse, cp, ville, tel, acompte, idHotel, idLigue) VALUES 
						('Honnête','Camille','17 Rue de la République','69003','Lyon','0604104136',250,1,1),
						('Evitable','Céline','65 Rue des Coudriers','03000','Moulins','0624311773',100,2,3),
						('Deuf','John','59 Rue Marie De Médicis','69300','Caluire-et-Cuire','0640443552',50,4,2),
						('Bricot','Judas','4 Rue du Clair Bocage','94210','La Varenne-Saint-Hilaire','0605525735',0,3,4),
						('Cament','Medhi','5 Rue Jean Vilar','24100','Bergerac','0637738864',150,5,10),
						('Fasol','Rémi','11 Place de la Madeleine','75012','Paris','0661679918',300,7,9),
						('Atrovite','Yves','80 Rue Frédéric Chopin','27200','Vernon','0615991385',275,6,8),
						('Térieur','Alex','6 Place de la Gare','77380','Combs-La-Ville','0609819631',225,9,7),
						('Javel','Aude','64 Rue Reine Elisabeth','77000','Melun','0645470780',125,10,6),
						('Sonne','Jacques','75 Rue des Nations Unies','42400','Saint-Chamond','0657085940',175,1,5),
						('Registre','Jean','39 Chemin Des Bateliers','49100','Angers','0670356136',75,2,1),
						('Némard','Jean','49 Avenue de l''Amandier','41000','Blois','0619135500',25,4,3),
						('Covert','Harry','95 Avenue de Bouvines','34200','Sète','0602844543',350,6,5),
						('Sop','Alain','91 Avenue de Provence','06220','Vallauris','0683111478',325,10,7),
						('Gole','Henri','99 Rue Petite Fusterie','38300','Bourgoin-Jallieu','0689944239',100,1,9),
						('Copter','Eli','7 Rue de la Hulotais','02100','Saint-Quentin','0679677567',250,3,10),
						('Conda','Anna','58 Boulevard de la Liberation','13014','Marseille','0649997855',150,5,7),
						('Croche','Sarah','80 Rue Lenotre','35000','Rennes','0645697884',130,7,4),
						('Mansoif','Gérard','78 Avenue Voltaire','71000','Mâcon','0635558609',80,9,9),
						('Croc','Odile','30 Rue de Groussay','12000','Rodez','0653439296',90,9,6),
						('Hévient','Eva','89 Rue Roussy','45160','Olivet','0651720487',110,1,8),
						('Mauve','Guy','28 Boulevard Aristide Briand','06110','Le Cannet','0677703053',120,2,1),
						('Assain','Marc','30 Rue Sadi Carnot','32000','Auch','0666515092',130,3,1),
						('Serrien','Jean','77 rue Pierre De Coubertin','31000','Toulouse','0618960416',140,4,2),
						('Riga','Tony','64 Chemin Du Lavarin Sud','14000','Caen','0667864358',240,5,3),
						('Brouard','Sophie','500 Avenue de Vanières','34070','Montpellier','0631387186',340,6,2),
						('Stiqué','Sophie','47 Rue Saint Germain','05000','Gap','0624051110',255,7,5),
						('Draté','Daisy','31 Rue Reine Elisabeth','48000','Mende','0696034382',155,9,6),
						('Rest','Eve','74 rue Lenotre','51100','Reims','0697533403',25,10,7),
						('Tomie','Anna','94 route de Lyon','13800','Istres','0671034621',90,6,8);

INSERT INTO Activite (designation, prix, date, heureDebut, nbPlacesMax) VALUES
					 ('Initiation au VoleyBall', 10.00, '2023-06-18', '09:00', 15),
					 ('Tournoi de Polo', 20.00, '2023-06-18', '14:30', 8),
				     ('Séance de Sophrologie', 35.00, '2023-06-18', '09:00', 20),
					 ('Remise en forme : débutants seulement', 8.00, '2023-06-18', '14:30', 15), 
				     ('Cours d''Etirement Collectif', 3.00, '2023-06-19', '09:00', 150),
				     ('Escalade de bloc : pour grimpeurs débutants et confirmés', 7.00, '2023-06-19', '14:30', 10),
					 ('Course en sacs', 3.00, '2023-06-19', '14:30', 40),
					 ('Cours intensif de Salsa: réservé aux danseurs confirmés', 45.00, '2023-06-19', '09:00', 10),
					 ('Inititation à l''apnée', 12.00, '2023-06-19', '09:00', 4), 
					 ('Découverte de la Spéléologie', 40.00, '2023-06-19', '14:30', 3),
					 ('Démonstration de figures de sports extrêmes', 4.00, '2023-06-20', '09:00', 40),
					 ('Course de Karting', 13.00, '2023-06-20', '14:30', 8),
					 ('Découverte de la Pelote Basque', 7.00, '2023-06-20', '14:30', 25),
					 ('Séance de méditation : Le sport et moi', 20.00, '2023-06-20', '09:00', 20), 
				     ('Rencontre finale intersportive', 5.00, '2023-06-21', '09:00', 200);						
				

	
select * from Session
select * from Congressiste

--FAURE Bryce Trigger
go
Create or alter Trigger TIU_Participer on Participer
after insert, update
as 
begin
	if (exists(select S.numSession from Participer P JOIN Session S on S.numSession = P.numSession group by S.numSession, S.nbPlacesMax Having COUNT(numInscription)>S.nbPlacesMax) )
		throw 50001, 'insertion ou update non valide dans la table Participer (Incription > nbPlacesMax) ! ! !', 0
end
go
Create or alter Trigger TIU_Inscrire on Inscrire
after insert, update
as 
begin
	if (exists(select I.idActivite, COUNT(numInscription) from Inscrire I JOIN Activite A on I.idActivite = A.idActivite group by I.idActivite, A.nbPlacesMax Having COUNT(numInscription)>A.nbPlacesMax) )
		throw 50002, 'insertion ou update non valide dans la table Inscrire (Incription > nbPlacesMax) ! ! !', 0
end
go
--FAURE Bryce Trigger Fin

--FAURE Bryce Procedure
Create or alter Procedure nbPlacesActivite
@uneActivite int
AS
BEGIN
	Select nbPlacesMax
	from Activite
	where idActivite = @uneActivite
END;

exec nbPlacesActivite '1'
go 
--FAURE Bryce Procedure Fin

Create or alter Procedure montantTotal
@numInscription int, @total int output
AS
BEGIN
	Declare @sumActivite int, @sumSession int, @priHotel int
	
	select @sumActivite = SUM(prix)
	from Inscrire I
	JOIN Activite A on A.idActivite = I.idActivite
	where numInscription = @numInscription

	select @sumSession = SUM(prix)
	from Participer P
	JOIN Session S on S.numSession = P.numSession
	where numInscription = @numInscription

	select @priHotel = prixChambre 
	from Hotel H 
	JOIN Congressiste C on C.idHotel = H.idHotel 
	where numInscription = @numInscription

	set @total = @sumActivite + @sumSession + (@priHotel*4)

	--select (prixChambre*4) + SUM(S.prix) + SUM(A.prix)
	--From Congressiste C 
	--	JOIN Hotel H on C.idHotel = H.idHotel 
	--	JOIN Inscrire I on I.numInscription = C.numInscription 
	--	JOIN Participer P on P.numInscription = C.numInscription 
	--	JOIN Activite A on A.idActivite = I.idActivite
	--	JOIN Session S on S.numSession = P.numSession 
	--where C.numInscription = 1
	--group by H.idHotel,H.prixChambre

END;
go

Declare @total2 int;
exec montantTotal '1',@total2 output
print @total2
go 

select * from Participer

select * from Inscrire
delete from Inscrire where idActivite = 1 or idActivite = 3 or idActivite = 4 or idActivite = 5 or idActivite = 6 or idActivite = 7 or idActivite = 8 or idActivite = 9 or idActivite = 10 or idActivite = 11 or idActivite = 12 or idActivite = 13 or idActivite = 14 or  idActivite = 15

INSERT INTO INSCRIRE(idActivite,numInscription) 
VALUES (1,1),(1,2),(1,4),(1,6),(1,8),(1,10),(1,12),(1,14),(1,16),(1,18),(1,20),(1,22),
(3,17),(3,19),(3,21),(3,23),(3,25),(3,27),(3,29),                                                       
(4,5),(4,6),(4,8),                                                       
(5,3),(5,7),(5,9),(5,11),(5,13),(5,15),                                                       
(6,25),(6,27),(6,29),(6,30),                                                       
(7,16),(7,18),(7,20),(7,21),                                                       
(8,2),(8,24),(8,26),(8,28),                                                       
(9,4),(9,5),(9,6),(9,16),                                                       
(10,6),(10,12),(10,14),                                                       
(11,6),(11,12),(11,14),(11,22),                                                       
(12,5),(12,7),(12,9),(12,30),                                                       
(13,13),(13,22),(13,26),                                                       
(14,8),(14,9),(14,13),(14,15),                                                       
(15,1),(15,2),(15,3),(15,4),(15,5),(15,6),(15,7),(15,8),(15,9),(15,10),(15,11),(15,12),(15,13),(15,14),(15,15),(15,16),
(15,17),(15,18),(15,19),(15,20),(15,21),(15,22),(15,23),(15,24),(15,25),(15,26),(15,27),(15,28),(15,29),(15,30);

INSERT INTO Participer(numSession,numInscription) VALUES 
(1,1),(1,2),(1,3),(1,4),(1,5),(1,6),(1,7),(1,8),(1,9),(1,10),(1,11),(1,12),(1,13),(1,14),(1,15),(1,16),
(1,17),(1,18),(1,19),(1,20),(1,21),(1,22),(1,23),(1,24),(1,25),(1,26),(1,27),(1,28),(1,29),(1,30),                                                         
(2,1),(2,2),(2,3),(2,4),(2,5),(2,6),(2,7),(2,8),(2,9),                                                         
(3,11),(3,12),(3,13),(3,14),(3,15),(3,16),(3,17),(3,18),(3,19),                                                         
(5,21),(5,22),(5,23),                                                        
(6,10),(6,20),(6,30),                                                         
(7,3),(7,5),(7,7),                                                         
(8,13),(8,15),                                                         
(9,26),(9,28),                                                         
(10,24),(10,30),                                                         
(11,9),(11,11),(11,17),                                                         
(12,19),(12,21),(12,23),(12,24),                                                         
(13,1),(13,16),(13,26),(13,30),                                                         
(14,2),(14,17),(14,27),(14,29),                                                         
(15,3),(15,8),(15,12),(15,20),                                                         
(16,4),(16,10),(16,14),(16,21),                                                         
(18,1),(18,2),(18,3),(18,4),(18,5),(18,6),(18,7),(18,8),(18,9),(18,10),(18,11),(18,12),(18,13),(18,14),(18,15),(18,16);
