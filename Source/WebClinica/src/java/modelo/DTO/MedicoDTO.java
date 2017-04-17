/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package modelo.DTO;

import java.sql.Date;

/**
 *
 * @author Romanet
 */
public class MedicoDTO {
 
    private int id;
    private Date fechaCreacion;
    private int rut;
    private String dv;
    private String paterno;
    private String materno;
    private String nombres;
    private String email;
    private String clave;
    private int minutosAtencion;
    private CentroMedicoDTO centroMedicoDTO;
    private EspecialidadDTO especialidadDTO;

    public MedicoDTO() {
        
    }

    public MedicoDTO(int id, Date fechaCreacion, int rut, String dv, String paterno, String materno, String nombres, String email, String clave, int minutosAtencion, CentroMedicoDTO centroMedicoDTO, EspecialidadDTO especialidadDTO) {
        this.id = id;
        this.fechaCreacion = fechaCreacion;
        this.rut = rut;
        this.dv = dv;
        this.paterno = paterno;
        this.materno = materno;
        this.nombres = nombres;
        this.email = email;
        this.clave = clave;
        this.minutosAtencion = minutosAtencion;
        this.centroMedicoDTO = centroMedicoDTO;
        this.especialidadDTO = especialidadDTO;
    }

    public EspecialidadDTO getEspecialidadDTO() {
        return especialidadDTO;
    }

    public void setEspecialidadDTO(EspecialidadDTO especialidadDTO) {
        this.especialidadDTO = especialidadDTO;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public Date getFechaCreacion() {
        return fechaCreacion;
    }

    public void setFechaCreacion(Date fechaCreacion) {
        this.fechaCreacion = fechaCreacion;
    }

    public int getRut() {
        return rut;
    }

    public void setRut(int rut) {
        this.rut = rut;
    }

    public String getDv() {
        return dv;
    }

    public void setDv(String dv) {
        this.dv = dv;
    }

    public String getPaterno() {
        return paterno;
    }

    public void setPaterno(String paterno) {
        this.paterno = paterno;
    }

    public String getMaterno() {
        return materno;
    }

    public void setMaterno(String materno) {
        this.materno = materno;
    }

    public String getNombres() {
        return nombres;
    }

    public void setNombres(String nombres) {
        this.nombres = nombres;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getClave() {
        return clave;
    }

    public void setClave(String calve) {
        this.clave = calve;
    }

    public int getMinutosAtencion() {
        return minutosAtencion;
    }

    public void setMinutosAtencion(int minutosAtencion) {
        this.minutosAtencion = minutosAtencion;
    }

    public CentroMedicoDTO getCentroMedicoDTO() {
        return centroMedicoDTO;
    }

    public void setCentroMedicoDTO(CentroMedicoDTO centroMedicoDTO) {
        this.centroMedicoDTO = centroMedicoDTO;
    }
    
    
}
  