using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;

namespace API_SECOPLA_KPL.Models
{
   
        [Table("kds_levantamiento")]
        public class FormLevantamiento
        {
            [Key]
            public string? planta { get; set; }
            public string? id_prospecto { get; set; }
            public string? asesor_asignado { get; set; }
            public string? estatus { get; set; }
            public string? zona { get; set; }
            public string? region { get; set; }
            public string? direccion { get; set; }
            public DateTime? fecha_levantamiento { get; set; }
            public string? nombre_contacto { get; set; }
            public string? nombre_empresa { get; set; }
            public string? direccion_empresa { get; set; }
            public string? ubicacion { get; set; }
            public string? contacto_comercial { get; set; }
            public string? mail_comercial { get; set; }
            public string? telefono_comercial { get; set; }
            public string? contacto_calidad { get; set; }
            public string? mail_calidad { get; set; }
            public string? telefono_calidad { get; set; }
            public string? giro_empresa { get; set; }
            public string? actividad_empresa { get; set; }
            public string? programa_seguridad { get; set; }
            public string? comentario_programa { get; set; }
            public string? requerimiento_salubridad { get; set; }
            public string? comentario_salubridad { get; set; }
            public string? normas_sanitarias { get; set; }
            public string? comentario_nsanitarias { get; set; }
            public string? identifica_plaga { get; set; }
            public string? fauna_domestica { get; set; }
            public string? tipo_domestica { get; set; }
            public string? fauna_silvestre { get; set; }
            public string? tipo_silvestre { get; set; }
            public string? insectos_voladores { get; set; }
            public string? tipo_voladores { get; set; }
            public string? insectos_rastreros { get; set; }
            public string? tipo_rastreros { get; set; }
            public string? fauna_aviar { get; set; }
            public string? tipo_aviar { get; set; }
            public string? desornitacion { get; set; }
            public string? comentario_desornitacion { get; set; }
            public string? gorgojo { get; set; }
            public string? comentario_gorgojo { get; set; }
            public string? roedores { get; set; }
            public string? comentario_roedor { get; set; } 
        //Segunda Parte
            public string? areas_conflictivas { get; set; }
            public string? escaleras { get; set; }
            public string? tipo_escalera { get; set; }
            public string? azoteas { get; set; }
            public string? tipo_azoteas { get; set; }
            public string? techos { get; set; }
            public string? tipo_techo { get; set; }
            public string? pasillos { get; set; }
            public string? tipo_pasillo { get; set; }
            public string? banios { get; set; }
            public string? tipo_banio { get; set; }
            public string? lockers { get; set; }
            public string? tipo_locker { get; set; }
            public string? andenes { get; set; }
            public string? tipo_anden { get; set; }
            public string? rampas { get; set; }
            public string? tipo_rampa { get; set; }
            public string? areas_produccion { get; set; }
            public string? tipo_produccion { get; set; }
            public string? areas_verdes { get; set; }
            public string? tipo_verdes { get; set; }
            public string? comedores { get; set; }
            public string? tipo_comedores { get; set; }
            public string? oficinas { get; set; }
            public string? tipo_oficina { get; set; }
            public string? almacen_mp { get; set; }
            public string? tipo_almacenmp { get; set; }
            public string? almacen_pt { get; set; }
            public string? tipo_almacenpt { get; set; }
            public string? almacen_empaque { get; set; }
            public string? tipo_empaque { get; set; }
        public string? tratadora_agua { get; set; }
        public string? tipo_tratadora { get; set; }
        public string? contenedor_basura { get; set; }
        public string? tipo_contenedor { get; set; }
        public string? silos { get; set; }
        public string? tipo_silos { get; set; }
        public string? tuneles { get; set; }
        public string? tipo_tuneles { get; set; }
        public string? bandas_transportadora { get; set; }
        public string? tipo_transportadora { get; set; }
        public string? unidades_reparto { get; set; }
        public string? tipo_unidades { get; set; }
        public string? tarimas { get; set; }
        public string? tipo_tarimas { get; set; }
        public string? talleres { get; set; }
        public string? tipo_talleres { get; set; }
        public string? camaras_refrigeracion { get; set; }
        public string? tipo_camaras { get; set; }
        public string? producto_noconforme { get; set; }
        public string? tipo_noconforme { get; set; }
        public string? otros_especificar { get; set; }
        public string? tipo_otros { get; set; }
        public string? lineamientos_auditados { get; set; }
        public string? tipo_auditados { get; set; }

        /**/
        public string? programas_formacion { get; set; }
        public string? programas_mantto { get; set; }
        public string? area_oportunidad { get; set; }
        public string? programas_almacenamiento { get; set; }
        public string? detalle_programa { get; set; }
        public string? infraestructura { get; set;}
        public string? zonas_mantto { get; set; }

        /*¿Los técnicos / instaladores deben de cumplir con requisitos específicos para su ingreso? Como los siguientes
         */
        public string? equipo_comunicacion { get; set; }
        public string? tipo_equipo { get; set; }
        public string? equipo_epp { get; set; }
        public string? tipo_epp { get; set; }
        public string? acceso_interno { get; set; }
        public string? tipo_acceso { get; set; }
        public string? horarios { get; set; }
        public string? tipo_horario { get; set; }
        public string? examenes_medicos { get; set; }
        public string? tipo_examenmedico { get; set; }
        public string? frecuencia_examen { get; set; }
        public string? tipo_frecuencia { get; set; }
        public string? carta_antecedentes { get; set; }
        public string? tipo_carta { get; set; }
        public string? imss { get; set; }
        public string? documento_imss { get; set; }
        public string? credencial_identificacion { get; set; }
        public string? tipo_identificacion { get; set; }
        public string? dias_capacitacion { get; set; }
        public string? tipo_dias { get; set; }
        public string? capacitacion_empresa { get; set; }
        public string? tipo_capacitacionemp { get; set; }
        public string? planeacion_visitas { get; set; }
        public string? tipo_planeacion { get; set; }
        public string? dc3 { get; set; }
        public string? tipo_dc3 { get; set; }
        public string? resguardo_equipos { get; set; }
        public string? zona_resguardo { get; set; }
        /*¿Los técnicos / instaladores deben de cumplir con requisitos específicos para su ingreso? Como los siguientes
         * 
         */
        /******************************************************/
        /*REQUERIMIENTOS COMERCIALES Y LEGALES
         */
        public string? orden_compra { get; set; }
        public string? oc_comentario { get; set; }
        public string? contrato { get; set; }
        public string? contrato_comentario { get; set; }
        public decimal? periodo_servicio { get; set; }
        public string? servicio_contratado { get; set; }
        public string? periodo_comentario { get; set; }
        public string? carpeta_fisica { get; set; }
        public string? fisica_comentario { get; set; }
        public string? carpeta_digital { get; set; }
        public string? digital_comentario { get; set; }
        public string? portal_factura { get; set; }
        public string? portal_comentario { get; set; }
        public string? fianza { get; set; }
        public string? fianza_comentario { get; set; }
        public string? sindical { get; set; }
        public string? sindical_comentario { get; set; }
        /*REQUERIMIENTOS COMERCIALES Y LEGALES
         */

        /*MEDIO AMBIENTE.													
         */
        public string? plagas_region { get; set; }
        public string? colindancia { get; set; }
        /*MEDIO AMBIENTE
         */

        /*LAY OUT / MEDIDAS													
         *
         * */
        public string? layout_cliente { get; set; }
        public string? urlimagen { get; set; }
        public decimal? m2_terreno { get; set; }
        public decimal? m2_construcciom { get; set; }
        public decimal? m3 { get; set; }
        /*LAY OUT / MEDIDAS													
         *
         * */

        /*INFORMACIÓN PARA ELABORAR PROPUESTA
         */
        public decimal? cebadero_a_actual { get; set; }
        public decimal? cebadero_a_requerido { get; set; }
        public string? cebadero_a_comentarios { get; set; }
        public decimal? cebadero_b_actual { get; set; }
        public decimal? cebadero_b_requerido { get; set; }
        public string? cebadero_b_comentarios { get; set; }
        public decimal? mecanicas_c_actual { get; set; }
        public decimal? mecanicas_c_requerido { get; set; }
        public string? trapper { get; set; }
        public string? metalicas { get; set; }
        public decimal? trex_actual { get; set; }
        public decimal? trex_requerido { get; set; }
        public string? trex_comentarios { get; set; }
        public decimal? gomasroedor_actual { get; set; }
        public decimal? gomasroedor_requerido { get; set; }
        public string? gomasroedor_comentarios { get; set; }
        public decimal? gomasinsecto_actual { get; set; }
        public decimal? gomasinsecto_requerido { get; set; }
        public string? gomasinsecto_comentarios { get; set; }
        public decimal? lln_actual { get; set; }
        public decimal? lln_requerido { get; set; }
        public string? lln_comentarios { get; set; }
        public decimal? electrocutadores_actual { get; set; }
        public decimal? electrocutadores_requerido { get; set; }
        public string? electrocutadores_comentarios { get; set; }
        public decimal? dispensadores_actual { get; set; }
        public decimal? dispensadores_requerido { get; set; }
        public string? dispensadores_comentarios { get; set; }
        public decimal? jaulas_actual { get; set; }
        public decimal? jaulas_requerido { get; set; }
        public string? jaulas_comentarios { get; set; }
        public decimal? bebederos_actual { get; set; }
        public decimal? bebederos_requerido { get; set; }
        public string? bebederos_comentarios { get; set; }
        public decimal? feromonas_actual { get; set; }
        public decimal? feromonas_requerido { get; set; }
        public string? feromonas_comentarios { get; set; }
        public decimal? tratamiento_mosca_actual { get; set; }
        public decimal? tratamiento_mosca_requerido { get; set; }
        public string? tratamiento_mosca_comentarios { get; set; }
        public decimal? otros_actual { get; set; }
        public decimal? otros_requerido { get; set; }
        public string? otros_comentarios { get; set; }
        public decimal? tecnico_fijo_actual { get; set; }
        public decimal? tecnico_fijo_requerido { get; set; }
        public string? tecnico_fijo_comentarios { get; set; }
        public decimal? tecnico_zona_actual { get; set; }
        public decimal? tecnico_zona_requerido { get; set; }
        public string? tecnico_zona_comentarios { get; set; }
        public decimal? tecnico_ruta_actual { get; set; }
        public decimal? tecnico_ruta_requerido { get; set; }
        public string? tecnico_ruta_comentarios { get; set; }
        public decimal? distancia_tecnico_actual { get; set; }
        public decimal? distancia_tecnico_requerido { get; set; }
        public string? distancia_tecnico_comentarios { get; set; }
        public decimal? frecuencia_aspersion_actual { get; set; }
        public decimal? frecuencia_aspersion_requerido { get; set; }
        public string? frecuencia_aspersion_comentarios { get; set; }
        public decimal? frecuencia_nebulizacion_actual { get; set; }
        public decimal? frecuencia_nebulizacion_requerido { get; set; }
        public string? frecuencia_nebulizacion_comentaros { get; set; }
        public decimal? frecuencia_termo_actual { get; set; }
        public decimal? frecuencia_termo_requerido { get; set; }
        public string? frecuencia_termo_comentarios { get; set; }
        public decimal? tratamiento_unidades_actual { get; set; }
        public decimal? tratamiento_unidades_requerido { get; set; }
        public string? tratamiento_unidades_comentarios { get; set; }
        public decimal? tratamiento_tarimas_actual { get; set; }
        public decimal? tratamiento_tarimas_requerido { get; set; }
        public string? tratamiento_tarimas_comentarios { get; set; }
        public decimal? equipo_comodato_actual { get; set; }
        public decimal? equipo_comodato_requerido { get; set; }
        public string? equipo_comodato_comentarios { get; set; }
        public decimal? equipo_propio_actual { get; set; }
        public decimal? equipo_propio_requerido { get; set; }
        public string? equipo_propio_comentarios { get; set; }
        public decimal? tratamiento_drenaje_actual { get; set; }
        public decimal? tratamiento_drenaje_requerido { get; set; }
        public string? tratamiento_drenaje_comentarios { get; set; }
        /*INFORMACIÓN PARA ELABORAR 
         */

        public string? malla { get; set; }
        public string? pared { get; set; }
        public string? varillas_anclar { get; set; }
        //**//
        public string? tipo_superficie { get; set; }
        public string? tipo_instalacion { get; set; }

        public string? proveedor_actual { get; set; }
        public string? comentarios_generales { get; set; }

    }
}
