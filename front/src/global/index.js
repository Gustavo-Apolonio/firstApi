import { createGlobalStyle } from "styled-components";

const GlobalStyle = createGlobalStyle`
  *{
    padding: 0;
    margin: 0;
    box-sizing: border-box;
  }
  body, html{
    height: 100vh;
    width: 100vw;

    font-size: 1em;
  }
`;

export default GlobalStyle;
