body {
    margin: 0;
    overflow: hidden;
    background: #000;
}

/* Container da galáxia */
.galaxy {
    position: absolute;
    width: 100%;
    height: 100%;
    background: radial-gradient(circle, rgba(63,94,251,1) 0%, rgba(252,70,107,1) 100%);
    overflow: hidden;
}

/* Estrelas */
.galaxy::before, .galaxy::after {
    content: '';
    position: absolute;
    top: 0;
    left: 0;
    width: 200%;
    height: 200%;
    background: transparent;
    box-shadow: 
        0 0 2px #fff, 0 0 4px #fff, 0 0 6px #fff, 0 0 8px #fff, 
        0 0 10px #fff, 0 0 12px #fff, 0 0 14px #fff, 0 0 16px #fff;
    animation: moveStars 50s linear infinite;
}

/* Animação das estrelas */
@keyframes moveStars {
    from {
        transform: translateY(0);
    }
    to {
        transform: translateY(-100%);
    }
}