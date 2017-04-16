-- Generado por Oracle SQL Developer Data Modeler 4.1.0.881
--   en:        2017-04-15 15:26:05 ART
--   sitio:      Oracle Database 11g
--   tipo:      Oracle Database 11g




DROP TABLE Agenda CASCADE CONSTRAINTS ;

DROP TABLE Calendario_Base CASCADE CONSTRAINTS ;

DROP TABLE Centro_Medico CASCADE CONSTRAINTS ;

DROP TABLE Disponibilidad CASCADE CONSTRAINTS ;

DROP TABLE Especialidad CASCADE CONSTRAINTS ;

DROP TABLE Medico CASCADE CONSTRAINTS ;

DROP TABLE Secretaria CASCADE CONSTRAINTS ;

CREATE TABLE Agenda
  (
    Id           NUMBER (7) NOT NULL ,
    Fecha        DATE NOT NULL ,
    Hora_Inicio  DATE NOT NULL ,
    Hora_Termino DATE NOT NULL ,
    Medico_Id    NUMBER (7) NOT NULL
  ) ;
ALTER TABLE Agenda ADD CONSTRAINT Agenda_PKv2 PRIMARY KEY ( Id ) ;

CREATE TABLE Calendario_Base
  (
    Id               NUMBER (7) NOT NULL ,
    Fecha            DATE NOT NULL ,
    Motivo           VARCHAR2 (255 CHAR) ,
    Centro_Medico_Id NUMBER (7) NOT NULL
  ) ;
ALTER TABLE Calendario_Base ADD CONSTRAINT Calendario_Base_PKv3 PRIMARY KEY ( Id ) ;

CREATE TABLE Centro_Medico
  (
    Id        NUMBER (7) NOT NULL ,
    Rut       NUMBER (9) NOT NULL ,
    Dv        VARCHAR2 (1 CHAR) NOT NULL ,
    Nombre    VARCHAR2 (100 CHAR) NOT NULL ,
    Direccion VARCHAR2 (255 CHAR) NOT NULL ,
    Telefono  NUMBER (9) NOT NULL ,
    Email     VARCHAR2 (25 CHAR) NOT NULL
  ) ;
ALTER TABLE Centro_Medico ADD CONSTRAINT Centro_Medico_PKv3 PRIMARY KEY ( Id ) ;
ALTER TABLE Centro_Medico ADD CONSTRAINT Centro_Medico_Rut_UNv3 UNIQUE ( Rut ) ;
ALTER TABLE Centro_Medico ADD CONSTRAINT Centro_Medico_Email_UNv3 UNIQUE ( Email ) ;

CREATE TABLE Disponibilidad
  (
    Id           NUMBER (7) NOT NULL , -- CAMBIAR ESTA WEA EN EL MODELER LENGHT 11
    Hora_Inicio  DATE NOT NULL ,
    Hora_Termino DATE NOT NULL ,
    Lunes        SMALLINT NOT NULL ,
    Martes       SMALLINT NOT NULL ,
    Miercoles    SMALLINT NOT NULL ,
    Jueves       SMALLINT NOT NULL ,
    Viernes      SMALLINT NOT NULL ,
    Sabado       SMALLINT NOT NULL ,
    Domingo      SMALLINT NOT NULL ,
    Medico_Id    NUMBER (7) NOT NULL
  ) ;
ALTER TABLE Disponibilidad ADD CONSTRAINT Disponibilidad_PKv3 PRIMARY KEY ( Id ) ;

CREATE TABLE Especialidad
  (
    Id     NUMBER (7) NOT NULL ,
    Nombre VARCHAR2 (50 CHAR) NOT NULL
  ) ;
ALTER TABLE Especialidad ADD CONSTRAINT Especialidad_PKv3 PRIMARY KEY ( Id ) ;

CREATE TABLE Medico
  (
    Id               NUMBER (7) NOT NULL ,
    Fecha_Creacion   DATE NOT NULL ,
    Rut              NUMBER (8) NOT NULL ,
    Dv               VARCHAR2 (1 CHAR) NOT NULL ,
    Paterno          VARCHAR2 (100 CHAR) NOT NULL ,
    Materno          VARCHAR2 (100 CHAR) NOT NULL ,
    Nombres          VARCHAR2 (100 CHAR) NOT NULL ,
    Email            VARCHAR2 (25 CHAR) NOT NULL ,
    Clave            VARCHAR2 (64 CHAR) NOT NULL ,
    Minutos_Atencion NUMBER (3) NOT NULL ,
    Centro_Medico_Id NUMBER (7) NOT NULL ,
    Especialidad_Id  NUMBER (7) NOT NULL
  ) ;
ALTER TABLE Medico ADD CONSTRAINT Medico_PKv3 PRIMARY KEY ( Id ) ;
ALTER TABLE Medico ADD CONSTRAINT Medico_Rut_UNv3 UNIQUE ( Rut ) ;
ALTER TABLE Medico ADD CONSTRAINT Medico_Email_UNv3 UNIQUE ( Email ) ;

CREATE TABLE Secretaria
  (
    Id               NUMBER (7) NOT NULL ,
    Fecha_Creacion   DATE NOT NULL ,
    Rut              NUMBER (8) NOT NULL ,
    Dv               VARCHAR2 (1 CHAR) NOT NULL ,
    Paterno          VARCHAR2 (100 CHAR) NOT NULL ,
    Materno          VARCHAR2 (100 CHAR) NOT NULL ,
    Nombres          VARCHAR2 (100 CHAR) NOT NULL ,
    Email            VARCHAR2 (25 CHAR) NOT NULL ,
    Clave            VARCHAR2 (64 CHAR) NOT NULL ,
    Centro_Medico_Id NUMBER (7) NOT NULL
  ) ;
ALTER TABLE Secretaria ADD CONSTRAINT Secretaria_PKv1 PRIMARY KEY ( Id ) ;
ALTER TABLE Secretaria ADD CONSTRAINT Secretaria_Rut_UNv1 UNIQUE ( Rut ) ;
ALTER TABLE Secretaria ADD CONSTRAINT Secretaria_Email_UNv1 UNIQUE ( Email ) ;

ALTER TABLE Agenda ADD CONSTRAINT Agenda_Medico_FK FOREIGN KEY ( Medico_Id ) REFERENCES Medico ( Id ) ;

--  ERROR: FK name length exceeds maximum allowed length(30)
ALTER TABLE Calendario_Base ADD CONSTRAINT CBase_CMedico_FK FOREIGN KEY ( Centro_Medico_Id ) REFERENCES Centro_Medico ( Id ) ;

ALTER TABLE Disponibilidad ADD CONSTRAINT Disponibilidad_Medico_FK FOREIGN KEY ( Medico_Id ) REFERENCES Medico ( Id ) ;

ALTER TABLE Medico ADD CONSTRAINT Medico_Centro_Medico_FK FOREIGN KEY ( Centro_Medico_Id ) REFERENCES Centro_Medico ( Id ) ;

ALTER TABLE Medico ADD CONSTRAINT Medico_Especialidad_FK FOREIGN KEY ( Especialidad_Id ) REFERENCES Especialidad ( Id ) ;

ALTER TABLE Secretaria ADD CONSTRAINT Secretaria_Centro_Medico_FK FOREIGN KEY ( Centro_Medico_Id ) REFERENCES Centro_Medico ( Id ) ;
