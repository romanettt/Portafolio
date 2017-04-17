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
public class CalendarioBaseDTO {
    
    private int id;
    private Date fecha;
    private String motivo;
    private CentroMedicoDTO centroMedicoDTO;
    
    public CalendarioBaseDTO() {
        
    }

    public CalendarioBaseDTO(int id, Date fecha, String motivo, CentroMedicoDTO centroMedicoDTO) {
        this.id = id;
        this.fecha = fecha;
        this.motivo = motivo;
        this.centroMedicoDTO = centroMedicoDTO;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public Date getFecha() {
        return fecha;
    }

    public void setFecha(Date fecha) {
        this.fecha = fecha;
    }

    public String getMotivo() {
        return motivo;
    }

    public void setMotivo(String motivo) {
        this.motivo = motivo;
    }

    public CentroMedicoDTO getCentroMedicoDTO() {
        return centroMedicoDTO;
    }

    public void setCentroMedicoDTO(CentroMedicoDTO centroMedicoDTO) {
        this.centroMedicoDTO = centroMedicoDTO;
    }
   
    
    

 
    
}
