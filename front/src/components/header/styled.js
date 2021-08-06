import styled from 'styled-components';

export const Container = styled.div`
    height: 10vh;
    width: 100%;

    background-color: rgba(0, 0, 0, .45);

    padding: 0.9em;

    display: flex;
    align-items: center;
    justify-content: center;
    
    p {
        margin: 0px;
        padding: 0px;
        
        font-size: 1.5em;
        font-weight: 500;
        text-shadow: 2px 1px 3px rgba(255, 255, 255, 80%);
    }
`;
