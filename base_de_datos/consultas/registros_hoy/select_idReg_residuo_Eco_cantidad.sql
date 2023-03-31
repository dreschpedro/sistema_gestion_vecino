SELECT registros_hoy.id_eco_resid AS id_registro,
residuo.id_residuo AS id_residuo,
residuo.nombre_residuo AS residuo,
ecopunto.id_ecopunto AS id_eco,
ecopunto.nombre AS N_eco,
registros_hoy.cantidad_residuo AS cantidad
FROM registros_hoy
JOIN residuo ON residuo.id_residuo = registros_hoy.id_residuo
JOIN ecopunto ON ecopunto.id_ecopunto = registros_hoy.id_ecopunto
ORDER BY registros_hoy.id_eco_resid

-- SELECT residuo.nombre_residuo AS residuo, registros_hoy.cantidad_residuo AS cantidad FROM residuo JOIN registros_hoy ON registros_hoy.id_residuo = residuo.id_residuo