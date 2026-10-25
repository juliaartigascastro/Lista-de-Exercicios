<?php
echo "Preço unitário (ex.: 12.50): ";
$preco = (float) trim(fgets(STDIN));
echo "Quantidade: ";
$quantidade = (int) trim(fgets(STDIN));

if ($preco < || $quantidade <= 0) {
    echo "Valores inválidos.\n";
    exit;
}
$total $preco $quantidade;
echo "Total: R$ . number format($total, 2,',', '.'). "\n";
