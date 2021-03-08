CREATE DATABASE DB_PersonalLife;
GO
USE DB_PersonalLife;

CREATE TABLE Sistema (
  idExercicio INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  exercicio NVARCHAR(20) NOT NULL UNIQUE,
  repeticao INT NOT NULL,
  descanso INT NOT NULL,
  sessao INT NOT NULL
);

CREATE TABLE Usuario (
  idUsuario INT NOT NULL PRIMARY KEY IDENTITY(1,1),
  nome NVARCHAR(50) NOT NULL,
  telefone NVARCHAR(11) NOT NULL,
  idade INT NOT NULL,
  altura FLOAT NOT NULL,
  peso FLOAT NOT NULL,
  metaPeso NVARCHAR(50),
  usuario NVARCHAR(50) NOT NULL UNIQUE,
  senha NVARCHAR(50) NOT NULL,
  email NVARCHAR(70) NOT NULL
);


CREATE TABLE ClienteExercicio(
  idExercicio INT,
  idUsuario INT,
  exercicio NVARCHAR(20),
  repeticao NVARCHAR(20),
  descanso NVARCHAR(20),
  sessao NVARCHAR(20),
  CONSTRAINT Fk_IdExercicio FOREIGN KEY(idExercicio)
   REFERENCES dbo.Sistema (idExercicio),
  CONSTRAINT Fk_IdUsuario FOREIGN KEY(idUsuario)
   REFERENCES dbo.Usuario (idUsuario)
 );

SELECT * FROM Sistema WHERE idExercicio != '5';

INSERT INTO Usuario VALUES ('b','1','1','1','20.7','Perder Peso','b','12345','b@pl.com');
SELECT * FROM ClienteExercicio WHERE idUsuario = 1;

SELECT c.idExercicio FROM Sistema as s, ClienteExercicio as c WHERE c.idExercicio != s.idExercicio;

SELECT s.exercicio, s.repeticao FROM Sistema as s, ClienteExercicio as c  WHERE s.idExercicio != c.idExercicio AND c.idUsuario = '1';

 INSERT INTO Usuario VALUES ('Pedro','11111111','17','1.81','60.5','Ganhar Massa','pedro','12345','pedro@pl.com'),
  ('Giovanny','22222222','18','1.75','59.6','Ganhar Massa','giovanny','12345','giovanny@pl.com'),
    ('Fernanda','33333333','18','1.71','59','Perder Peso','fernanda','12345','fernanda@pl.com'),
	  ('a','4','4','4','4','4','a','1','a@pl.com');

	  INSERT INTO ClienteExercicio VALUES ('1', '4', 'Abdominal', '30', '10', '4')

 INSERT INTO Sistema VALUES 
 ('Abdominal','20','30','4'),('Crucifixo','5','30','4'),('Prancha','1','30','4'),
   ('Elevação de Pernas','10','15','2'),('Crossover','10','15','2'),('Rosca Martelo','15','30','45'),
     ('Frontal','8','30','3'),('Supino Inclinado','10','60','3'),('Remada Alta','20','60','3'),
	   ('Bike','10','15','2'),('Supino Reto','12','45','60'),('Elevação Fontal','30','90','2'),
         ('Com Inversão','10','10','2'),('Mesa Flexora','5','30','4'),('Elevação Lateral','15','30','4');


