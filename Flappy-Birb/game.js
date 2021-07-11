console.log('Flappy Birb');

let frames = 0;

const soundHit = new Audio();
soundHit.src = './sounds/hit.wav';

const sprites = new Image();
sprites.src = './sprites.png';

const canvas = document.querySelector('canvas');
const context = canvas.getContext('2d');

function doCollision(flappyBirb, floor) {
  const flappyBirbY = flappyBirb.y + flappyBirb.h;
  const floorY = floor.y;

  return flappyBirbY >= floorY ? true : false;
}

function createFlappyBirb() {
  const flappyBirb = {
    sx: 0,
    sY: 0,
    w: 33,
    h: 24,
    x: 10,
    y: 50,
    jumpStrength: 4.6,
    jump() {
      flappyBirb.speed = - flappyBirb.jumpStrength;
    },
    speed: 0,
    gravity: 0.25,
    update() {
      if (doCollision(flappyBirb, globais.floor)) {
        // soundHit.play();

        setTimeout(() => {
          changeToScreen(Screens.begin);
        }, 500);

        return;
      }

      flappyBirb.speed = flappyBirb.speed + flappyBirb.gravity;
      flappyBirb.y = flappyBirb.y + flappyBirb.speed;
    },
    moves: [
      { spriteX: 0, spriteY: 0, }, // Wings up
      { spriteX: 0, spriteY: 26, }, // Wings in middle
      { spriteX: 0, spriteY: 52, }, // Wings down
    ],
    actualFrame: 0,
    updateActualFrame() {
      const frameInterval = 10;
      const hasPassedInterval = frames % frameInterval === 0;

      if (hasPassedInterval) {
        const incrementBase = 1;
        const increment = incrementBase + flappyBirb.actualFrame;
        const repeatBase = flappyBirb.moves.length;
        flappyBirb.actualFrame = increment % repeatBase;
      }
    },
    draw() {
      flappyBirb.updateActualFrame();
      const { spriteX, spriteY } = flappyBirb.moves[flappyBirb.actualFrame];

      context.drawImage(
        sprites,
        spriteX, spriteY,
        flappyBirb.w, flappyBirb.h,
        flappyBirb.x, flappyBirb.y,
        flappyBirb.w, flappyBirb.h,
      );
    },
  }

  return flappyBirb;
}

function createFloor() {
  const floor = {
    sx: 0,
    sY: 610,
    w: 224,
    h: 112,
    x: 0,
    y: canvas.height - 112,
    update() {
      const floorMove = 1;
      const repeatIn = floor.w / 2;
      const move = floor.x - floorMove;

      floor.x = move % repeatIn;
    },
    draw() {
      context.drawImage(
        sprites,
        floor.sx, floor.sY,
        floor.w, floor.h,
        floor.x, floor.y,
        floor.w, floor.h,
      );

      context.drawImage(
        sprites,
        floor.sx, floor.sY,
        floor.w, floor.h,
        (floor.x + floor.w), floor.y,
        floor.w, floor.h,
      );
    },
  }

  return floor;
}

function createTubes() {
  const tubes = {
    w: 52,
    h: 400,
    floor: {
      sX: 0,
      sY: 169,
    },
    heaven: {
      sX: 52,
      sY: 169,
    },
    space: 80,
    draw() {
      tubes.pairs.forEach(function(pair) {
        const yRandom = pair.y;
        const spaceBetween = 80;

        const tubeHeavenX = pair.x;
        const tubeHeavenY = yRandom;

        context.drawImage(
          sprites,
          tubes.heaven.sX, tubes.heaven.sY,
          tubes.w, tubes.h,
          tubeHeavenX, tubeHeavenY,
          tubes.w, tubes.h,
        );

        const tubeFloorX = pair.x;
        const tubeFloorY = tubes.h + spaceBetween + yRandom;

        context.drawImage(
          sprites,
          tubes.floor.sX, tubes.floor.sY,
          tubes.w, tubes.h,
          tubeFloorX, tubeFloorY,
          tubes.w, tubes.h,
        );

        pair.tubeHeaven = {
          x: tubeFloorX,
          y: tubes.h + tubeHeavenY
        }
        pair.tubeFloor = {
          x: tubeHeavenX,
          y: tubeFloorY
        }
      })
    },
    hasCollisionWithBirb(pair) {
      const birbHead = globais.flappyBirb.y;
      const birbFeet = globais.flappyBirb.y + globais.flappyBirb.h;

      if (globais.flappyBirb.x >= pair.x) {
        if(birbHead <= pair.tubeHeaven.y || birbFeet >= pair.tubeFloor.y)
          return true;
      };
    },
    pairs: [],
    update() {
      const passed100Frames = frames % 100 === 0;

      if (passed100Frames) {
        tubes.pairs.push({
          x: canvas.width,
          y: -150 * (Math.random() + 1),
        });
      }

      tubes.pairs.forEach(function(pair) {
        pair.x = pair.x -2;

        if(tubes.hasCollisionWithBirb(pair)) {
          changeToScreen(Screens.begin);
        }

        if(pair.x + tubes.w <= 0){
          tubes.pairs.shift();
        };

      });
    }
  }

  return tubes;
}


const background = {
  sX: 390,
  sY: 0,
  w: 275,
  h: 204,
  x: 0,
  y: canvas.height - 204,
  draw() {
    context.fillStyle = '#70c5ce';
    context.fillRect(0, 0, canvas.width, canvas.height);

    context.drawImage(
      sprites,
      background.sX, background.sY,
      background.w, background.h,
      background.x, background.y,
      background.w, background.h,
    );

    context.drawImage(
      sprites,
      background.sX, background.sY,
      background.w, background.h,
      (background.x + background.w), background.y,
      background.w, background.h,
    );
  },
}

const getReadyImage = {
  sX: 134,
  sY: 0,
  w: 174,
  h: 152,
  x: (canvas.width / 2) - 174 / 2,
  y: 50,
  draw() {
    context.drawImage(
      sprites,
      getReadyImage.sX, getReadyImage.sY,
      getReadyImage.w, getReadyImage.h,
      getReadyImage.x, getReadyImage.y,
      getReadyImage.w, getReadyImage.h,
    );
  },
}

/**
 * [Screens]
 */
const globais = {}

let activeScreen = {};
function changeToScreen(newScreen) {
  activeScreen = newScreen;

  if (activeScreen.init) {
    activeScreen.init();
  }
}

const Screens = {
  begin: {
    init() {
      globais.flappyBirb = createFlappyBirb();
      globais.floor = createFloor();
      globais.tubes = createTubes();
    },
    draw() {
      background.draw();
      globais.floor.draw();
      globais.flappyBirb.draw();
      getReadyImage.draw();
    },
    click() {
      changeToScreen(Screens.game);
    },
    update() {
      globais.floor.update();
    }
  },
  game: {
    draw() {
      background.draw();
      globais.tubes.draw();
      globais.floor.draw();
      globais.flappyBirb.draw();
    },
    click() {
      globais.flappyBirb.jump();
    },
    update() {
      globais.floor.update();
      globais.tubes.update();
      globais.flappyBirb.update();
    }
  }
}

function loop() {
  activeScreen.update();
  activeScreen.draw();
  requestAnimationFrame(loop);
  frames = frames + 1;
}

window.addEventListener('click', function () {
  if (activeScreen.click) {
    activeScreen.click();
  }
});

changeToScreen(Screens.begin);
loop();
