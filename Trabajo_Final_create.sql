-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2023-11-20 20:43:39.485

-- tables
-- Table: Empresa
CREATE TABLE Empresa (
    EmpresaId int  NOT NULL IDENTITY(1, 1),
    NombreEmpresa varchar(100)  NOT NULL,
    DireccionEmpresa varchar(100)  NOT NULL,
    CiudadEmpresa varchar(100)  NOT NULL,
    Activo bit  NOT NULL,
    Eliminado bit  NOT NULL,
    UsuarioCreacionId int  NOT NULL,
    FechaCreacion datetime  NOT NULL,
    UsuarioModificacionId int  NOT NULL,
    FechaModificacion datetime  NOT NULL,
    CONSTRAINT Empresa_pk PRIMARY KEY  (EmpresaId)
);

-- Table: Especialista
CREATE TABLE Especialista (
    EspecialistaId int  NOT NULL IDENTITY(1, 1),
    DniEspecialista varchar(50)  NOT NULL,
    Contrasena varchar(50)  NOT NULL,
    NombreEspecialista varchar(100)  NOT NULL,
    ApellidoEspecialista varchar(100)  NOT NULL,
    Ocupacion varchar(100)  NOT NULL,
    Activo bit  NOT NULL,
    Eliminado bit  NOT NULL,
    UsuarioCreacionId int  NOT NULL,
    FechaCreacion datetime  NOT NULL,
    UsuarioModificacionId int  NOT NULL,
    FechaModificacion datetime  NOT NULL,
    CONSTRAINT Especialista_pk PRIMARY KEY  (EspecialistaId)
);

-- Table: EspecialistaTrabajador
CREATE TABLE EspecialistaTrabajador (
    EspecialistaTrabajadorId int  NOT NULL IDENTITY(1, 1),
    AreaTrabajo varchar(100)  NOT NULL,
    Activo bit  NOT NULL,
    Eliminado bit  NOT NULL,
    Trabajador_TrabajadorId int  NOT NULL,
    Especialista_EspecialistaId int  NOT NULL,
    UsuarioCreacionId int  NOT NULL,
    FechaCreacion datetime  NOT NULL,
    UsuarioModificacionId int  NOT NULL,
    FechaModificacion datetime  NOT NULL,
    CONSTRAINT EspecialistaTrabajador_pk PRIMARY KEY  (EspecialistaTrabajadorId)
);

-- Table: RegistroConsumoMetabolico
CREATE TABLE RegistroConsumoMetabolico (
    RegistroConsumoMetabolicoId int  NOT NULL IDENTITY(1, 1),
    PosicionTrabajador varchar(100)  NOT NULL,
    TiempoPosicion int  NOT NULL,
    TipoTrabajo varchar(100)  NOT NULL,
    TiempoTrabajo int  NOT NULL,
    NivelHemoglobina float(10)  NOT NULL,
    RangoHemoglobina varchar(50)  NOT NULL,
    LaboratorioClinico varchar(50)  NOT NULL,
    Eliminado bit  NOT NULL,
    UsuarioCreacionId int  NOT NULL,
    FechaCreacion datetime  NOT NULL,
    UsuarioModificacionId int  NOT NULL,
    FechaModificacion datetime  NOT NULL,
    CONSTRAINT RegistroConsumoMetabolico_pk PRIMARY KEY  (RegistroConsumoMetabolicoId)
);

-- Table: RegistroMonitoreoErgonomico
CREATE TABLE RegistroMonitoreoErgonomico (
    RegistroMonitoreoErgonomicoId int  NOT NULL IDENTITY(1, 1),
    ErgonomiaDatos Varchar(100)  NOT NULL,
    TiempoDato int  NOT NULL,
    EquipamientoOficina varchar(100)  NOT NULL,
    TiempoEquipamiento int  NOT NULL,
    Eliminado bit  NOT NULL,
    UsuarioCreacionId int  NOT NULL,
    FechaCreacion datetime  NOT NULL,
    UsuarioModificacionId int  NOT NULL,
    FechaModificacion datetime  NOT NULL,
    CONSTRAINT RegistroMonitoreoErgonomico_pk PRIMARY KEY  (RegistroMonitoreoErgonomicoId)
);

-- Table: RegistroResistenciaTermica
CREATE TABLE RegistroResistenciaTermica (
    RegistroResistenciaTermicaId int  NOT NULL IDENTITY(1, 1),
    PrendaRopaInterior varchar(100)  NOT NULL,
    PrendaCamisa varchar(100)  NOT NULL,
    PrendaPantalones varchar(100)  NOT NULL,
    PrendaVestidos varchar(100)  NOT NULL,
    PrendaChaqueta varchar(100)  NOT NULL,
    Eliminado bit  NOT NULL,
    UsuarioCreacionId int  NOT NULL,
    FechaCreacion datetime  NOT NULL,
    UsuarioModificacionId int  NOT NULL,
    FechaModificacion datetime  NOT NULL,
    CONSTRAINT RegistroResistenciaTermica_pk PRIMARY KEY  (RegistroResistenciaTermicaId)
);

-- Table: RegistroTrabajador
CREATE TABLE RegistroTrabajador (
    RegistroTrabajadorId int  NOT NULL IDENTITY(1, 1),
    RegistroConsumoMetabolico_RegistroConsumoMetabolicoId int  NOT NULL,
    RegistroResistenciaTermica_RegistroResistenciaTermicaId int  NOT NULL,
    RegistroMonitoreoErgonomico_RegistroMonitoreoErgonomicoId int  NOT NULL,
    Trabajador_TrabajadorId int  NOT NULL,
    Eliminado bit  NOT NULL,
    UsuarioCreacionId int  NOT NULL,
    FechaCreacion datetime  NOT NULL,
    UsuarioModificacionId int  NOT NULL,
    FechaModificacion datetime  NOT NULL,
    CONSTRAINT RegistroTrabajador_pk PRIMARY KEY  (RegistroTrabajadorId)
);

-- Table: Trabajador
CREATE TABLE Trabajador (
    TrabajadorId int  NOT NULL IDENTITY(1, 1),
    DniTrabajador varchar(50)  NOT NULL,
    NombreTrabajador varchar(100)  NOT NULL,
    ApellidoTrabajador varchar(100)  NOT NULL,
    Activo bit  NOT NULL,
    Eliminado bit  NOT NULL,
    Empresa_EmpresaId int  NOT NULL,
    UsuarioCreacionId int  NOT NULL,
    FechaCreacion datetime  NOT NULL,
    UsuarioModificacionId int  NOT NULL,
    FechaModificacion datetime  NOT NULL,
    CONSTRAINT Trabajador_pk PRIMARY KEY  (TrabajadorId)
);

-- foreign keys
-- Reference: EspecialistaTrabajador_Especialista (table: EspecialistaTrabajador)
ALTER TABLE EspecialistaTrabajador ADD CONSTRAINT EspecialistaTrabajador_Especialista
    FOREIGN KEY (Especialista_EspecialistaId)
    REFERENCES Especialista (EspecialistaId);

-- Reference: EspecialistaTrabajador_Trabajador (table: EspecialistaTrabajador)
ALTER TABLE EspecialistaTrabajador ADD CONSTRAINT EspecialistaTrabajador_Trabajador
    FOREIGN KEY (Trabajador_TrabajadorId)
    REFERENCES Trabajador (TrabajadorId);

-- Reference: RegistroOcupacional_RegistroConsumoMetabolico (table: RegistroTrabajador)
ALTER TABLE RegistroTrabajador ADD CONSTRAINT RegistroOcupacional_RegistroConsumoMetabolico
    FOREIGN KEY (RegistroConsumoMetabolico_RegistroConsumoMetabolicoId)
    REFERENCES RegistroConsumoMetabolico (RegistroConsumoMetabolicoId);

-- Reference: RegistroOcupacional_RegistroMonitoreoErgonomico (table: RegistroTrabajador)
ALTER TABLE RegistroTrabajador ADD CONSTRAINT RegistroOcupacional_RegistroMonitoreoErgonomico
    FOREIGN KEY (RegistroMonitoreoErgonomico_RegistroMonitoreoErgonomicoId)
    REFERENCES RegistroMonitoreoErgonomico (RegistroMonitoreoErgonomicoId);

-- Reference: RegistroOcupacional_RegistroResistenciaTermica (table: RegistroTrabajador)
ALTER TABLE RegistroTrabajador ADD CONSTRAINT RegistroOcupacional_RegistroResistenciaTermica
    FOREIGN KEY (RegistroResistenciaTermica_RegistroResistenciaTermicaId)
    REFERENCES RegistroResistenciaTermica (RegistroResistenciaTermicaId);

-- Reference: RegistroOcupacional_Trabajador (table: RegistroTrabajador)
ALTER TABLE RegistroTrabajador ADD CONSTRAINT RegistroOcupacional_Trabajador
    FOREIGN KEY (Trabajador_TrabajadorId)
    REFERENCES Trabajador (TrabajadorId);

-- Reference: Trabajador_Empresa (table: Trabajador)
ALTER TABLE Trabajador ADD CONSTRAINT Trabajador_Empresa
    FOREIGN KEY (Empresa_EmpresaId)
    REFERENCES Empresa (EmpresaId);

-- End of file.

