import styled from 'styled-components';

export const Container = styled.div`
  height: 100vh;
  width: 100vw;

  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;

  background-image: url("/assets/images/enter.svg");
  background-repeat: no-repeat;
  background-position: bottom left;
  background-size: 38%;
`;

export const Entrar = styled.button`
  display: flex;
  align-items: center;
  justify-content: center;

  p {
    margin: 0px;
    padding: 1em;
  }
`;