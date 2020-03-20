import React from 'react';
import { render } from '@testing-library/react';
import '@testing-library/jest-dom/extend-expect';
import App from './App';

test('renders smart library text', () => {
  const { getByText } = render(<App />);
  const textElement = getByText(/Smart Library/i);
  expect(textElement).toBeInTheDocument();
});
